using DAL;
using DTO;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting
{
    [TestClass]
    public class DALCTPhieuNhap_Test
    {
        private DALCTPhieuNhap dalCTPhieuNhap;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<CT_PHIEUNHAP>> CTPhieuNhapDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            CTPhieuNhapDbSetMock = new Mock<DbSet<CT_PHIEUNHAP>>();
            dalCTPhieuNhap = new DALCTPhieuNhap(dbContextMock.Object);

            var list = new List<CT_PHIEUNHAP>
            {
                new CT_PHIEUNHAP {SoPhieuNhap = 1, idSach = 1, DonGia = 40000, SoLuongNhap  = 2, ThanhTien = 80000},
                new CT_PHIEUNHAP {SoPhieuNhap = 2, idSach = 2, DonGia = 40000, SoLuongNhap  = 2, ThanhTien = 80000},

            };

            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.CT_PHIEUNHAP).Returns(CTPhieuNhapDbSetMock.Object);
        }

        [TestMethod]
        public void GetAllCTPhieuNhap_ShouldReturnListOfPhieuNhap()
        {
            // Arrange
            var phieunhap = new CT_PHIEUNHAP { SoPhieuNhap = 1, idSach = 1, DonGia = 40000, SoLuongNhap  = 2, ThanhTien = 80000 };
            var data = new List<CT_PHIEUNHAP> { phieunhap };
            var mockData = data.AsQueryable();
            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Provider).Returns(mockData.Provider);
            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Expression).Returns(mockData.Expression);
            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());

            // Act

            List<CT_PHIEUNHAP> result = dalCTPhieuNhap.GetAllCTPhieuNhap();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void GetCTPhieuNhap_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var soPhieuNhap = 1;
            var idSach = 1;
            var phieunhap = new CT_PHIEUNHAP { SoPhieuNhap = soPhieuNhap, idSach = idSach, DonGia = 40000, SoLuongNhap  = 2, ThanhTien = 80000 };
            var data = new List<CT_PHIEUNHAP> { phieunhap };
            var mockData = data.AsQueryable();
            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Provider).Returns(mockData.Provider);
            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.Expression).Returns(mockData.Expression);
            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            CTPhieuNhapDbSetMock.As<IQueryable<CT_PHIEUNHAP>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());

            // Act
            CT_PHIEUNHAP result = dalCTPhieuNhap.GetCT_PHIEUNHAP(soPhieuNhap, idSach);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(soPhieuNhap, result.SoPhieuNhap);
            Assert.AreEqual(idSach, result.idSach);
        }

        [TestMethod]
        public void GetCTPhieuNhap_ShouldReturnNullForNonExistingPhieuNhap()
        {
            // Arrange

            var nonExistingsoPhieuNhap = 999;
            var nonExistingidSach = 888;

            // Act
            CT_PHIEUNHAP result = dalCTPhieuNhap.GetCT_PHIEUNHAP(nonExistingsoPhieuNhap, nonExistingidSach);

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void Test_AddCTPhieuNhap()
        {
            var phieuNhap = new CT_PHIEUNHAP { SoPhieuNhap = 1, idSach = 1, DonGia = 40000, SoLuongNhap  = 2, ThanhTien = 80000 };

            bool result = dalCTPhieuNhap.AddCTPhieuNhap(phieuNhap);

            Assert.IsTrue(result);

            dbContextMock.Verify(m => m.CT_PHIEUNHAP.Add(phieuNhap), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

        }


        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALCTPhieuNhap.Instance;
            var instance2 = DALCTPhieuNhap.Instance;

            // Assert
            Assert.IsNotNull(instance1);
            Assert.IsNotNull(instance2);
            Assert.AreSame(instance1, instance2);
        }

        [TestMethod]
        public void Constructor_WithDbContext_ShouldSetDbContext()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var dalInstance = new DALCTPhieuNhap(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALCTPhieuNhap();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }
    }
}
