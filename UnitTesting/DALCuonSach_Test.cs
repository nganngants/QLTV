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
    public class DALCuonSach_Test
    {
        private DALCuonSach dalCuonSach;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<CUONSACH>> cuonSachDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            cuonSachDbSetMock = new Mock<DbSet<CUONSACH>>();
            dalCuonSach = new DALCuonSach(dbContextMock.Object);

            var list = new List<CUONSACH>
            {
                new CUONSACH{id = 1, idSach = 1, MaCuonSach = "Sach001", DaAn = 1, TinhTrang =  1},
                 new CUONSACH{id = 2, idSach = 2, MaCuonSach = "Sach001", DaAn = 1, TinhTrang =  1},

            };

            cuonSachDbSetMock.As<IQueryable<CUONSACH>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            cuonSachDbSetMock.As<IQueryable<CUONSACH>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            cuonSachDbSetMock.As<IQueryable<CUONSACH>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            cuonSachDbSetMock.As<IQueryable<CUONSACH>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.CUONSACHes).Returns(cuonSachDbSetMock.Object);
        }

        [TestMethod]
        public void GetAllCuonSach_ShouldReturnListOfCuonSach()
        {
            // Arrange

            var cuonsach = new CUONSACH { id = 1, idSach = 1, MaCuonSach = "Sach001", DaAn = 1, TinhTrang =  1 };
            var data = new List<CUONSACH> { cuonsach };
            var mockData = data.AsQueryable();
            cuonSachDbSetMock.As<IQueryable<CUONSACH>>().Setup(m => m.Provider).Returns(mockData.Provider);
            cuonSachDbSetMock.As<IQueryable<CUONSACH>>().Setup(m => m.Expression).Returns(mockData.Expression);
            cuonSachDbSetMock.As<IQueryable<CUONSACH>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            cuonSachDbSetMock.As<IQueryable<CUONSACH>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());

            // Act

            List<CUONSACH> result = dalCuonSach.GetAllCuonSach();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void GetCuonSachById_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingCuonSachId = 1;
            var cuonsach = new CUONSACH { id = existingCuonSachId, idSach = 1, MaCuonSach = "Sach001", DaAn = 1, TinhTrang =  1 };
            dbContextMock.Setup(db => db.CUONSACHes.Find(cuonsach.id)).Returns(cuonsach);
            // Act
            CUONSACH result = dalCuonSach.GetCuonSachById(existingCuonSachId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingCuonSachId, result.id);
        }

        [TestMethod]
        public void GetCuonSachById_ShouldReturnNullForNonExistingCuonSach()
        {
            // Arrange

            var nonExistingCuonSachId = 999;

            // Act
            CUONSACH result = dalCuonSach.GetCuonSachById(nonExistingCuonSachId);

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void GetCuonSachByMa_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingMaCuonSach = "Sach001";
            var cuonsach = new CUONSACH { id = 1, idSach = 1, MaCuonSach = "Sach001", DaAn = 1, TinhTrang =  1 };
            dbContextMock.Setup(db => db.CUONSACHes.Find(cuonsach.id)).Returns(cuonsach);
            // Act
            CUONSACH result = dalCuonSach.GetCuonSachByMa(existingMaCuonSach);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingMaCuonSach, result.MaCuonSach);
        }

        [TestMethod]
        public void GetCuonSachByMa_ShouldReturnNullForNonExistingCuonSach()
        {
            // Arrange

            var nonExistingCuonSach= "NonExistingMaCuonSach";

            // Act
            CUONSACH result = dalCuonSach.GetCuonSachByMa(nonExistingCuonSach);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Test_AddCuonSach()
        {
            var cuonSach = new CUONSACH { id = 1, idSach = 1, MaCuonSach = "Sach001", DaAn = 1, TinhTrang =  1 };

            bool result = dalCuonSach.AddCuonSach(cuonSach);

            Assert.IsTrue(result);

            dbContextMock.Verify(m => m.CUONSACHes.Add(cuonSach), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void UpdCuonSach_ShouldUpdateExistingCuonSach()
        {
            // Arrange
            var idCuonSach = 1;
            var tinhTrang = 2;

            var sach = new SACH { id = 1, SoLuongConLai = 3, SoLuong = 1 };
            dbContextMock.Setup(db => db.SACHes.Find(sach.id)).Returns(sach);
            // Thiết lập dữ liệu giả mạo cho DbSet
            var existingCuongSach = new CUONSACH { id =idCuonSach, idSach = 1, MaCuonSach = "Sach001", DaAn = 1, TinhTrang =  1, SACH = sach };
            dbContextMock.Setup(db => db.CUONSACHes.Find(idCuonSach)).Returns(existingCuongSach);


            // Lưu giá trị ban đầu
            var initialTinhTrang = existingCuongSach.TinhTrang;

            // Act
            bool result = dalCuonSach.UpdCuonSach(idCuonSach, tinhTrang);

            // Assert
            Assert.IsTrue(result);



        }

        [TestMethod]
        public void UpdCuonSach_ShouldReturnFalseForNonExistingCuonSach()
        {
            // Arrange
            var idCuonSach = 33;
            var tinhTrang = 1;
            // Act
            bool result = dalCuonSach.UpdCuonSach(idCuonSach, tinhTrang);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DelCuonSach_ShouldUpdateExistingCuonSach()
        {
            // Arrange
            var idCuonSach = 1;
            var tinhTrang = 2;

            var sach = new SACH { id = 1, SoLuongConLai = 3, SoLuong = 1 };
            dbContextMock.Setup(db => db.SACHes.Find(sach.id)).Returns(sach);
            // Thiết lập dữ liệu giả mạo cho DbSet
            var existingCuongSach = new CUONSACH { id =idCuonSach, idSach = 1, MaCuonSach = "Sach001", DaAn = 1, TinhTrang =  1, SACH = sach };
            dbContextMock.Setup(db => db.CUONSACHes.Find(idCuonSach)).Returns(existingCuongSach);


            // Lưu giá trị ban đầu
            bool result = dalCuonSach.DelCuonSach(idCuonSach);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            cuonSachDbSetMock.Verify(m => m.Remove(existingCuongSach), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

        }

        [TestMethod]
        public void DelCuonSach_ShouldReturnFalseForNonExistingCuonSach()
        {
            // Arrange
            var idCuonSach = 33;
            var tinhTrang = 1;
            // Act
            bool result = dalCuonSach.DelCuonSach(idCuonSach);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void DelBaoCaoA_ShouldReturnFalseOnException()
        {
            // Arrange
            var idCuonSach = 44;
            
            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<CUONSACH>();

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALCuonSach(dbContextMock.Object);

            // Act
            var result = sut.DelCuonSach(idCuonSach);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UpdCuonSachDaAn_ShouldUpdateExistingCuonSach()
        {
            // Arrange
            var idCuonSach = 1;
            var daAn = 2;

            var sach = new SACH { id = 1, SoLuongConLai = 3, SoLuong = 1 };
            dbContextMock.Setup(db => db.SACHes.Find(sach.id)).Returns(sach);
            // Thiết lập dữ liệu giả mạo cho DbSet
            var existingCuongSach = new CUONSACH { id =idCuonSach, idSach = 1, MaCuonSach = "Sach001", DaAn = 1, TinhTrang =  1, SACH = sach };
            dbContextMock.Setup(db => db.CUONSACHes.Find(idCuonSach)).Returns(existingCuongSach);


            // Lưu giá trị ban đầu
            var initialTinhTrang = existingCuongSach.TinhTrang;

            // Act
            bool result = dalCuonSach.UpdAnCuonSach(idCuonSach, daAn);

            // Assert
            Assert.IsTrue(result);

            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

        }

        [TestMethod]
        public void UpdAnCuonSach_ShouldReturnFalseOnException()
        {
            // Arrange
            var idCuonSach = 44;
            
            var data = 2;
            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<CUONSACH>();

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALCuonSach(dbContextMock.Object);

            // Act
            var result = sut.UpdAnCuonSach(idCuonSach, data);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UpdCuonSach_ShouldReturnFalseOnException()
        {
            // Arrange
            var idCuonSach = 44;

            var tinhTrang = 2;
            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<CUONSACH>();

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALCuonSach(dbContextMock.Object);

            // Act
            var result = sut.UpdCuonSach(idCuonSach, tinhTrang);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void UpdCuonSachDaAn_ShouldReturnFalseForNonExistingCuonSach()
        {
            // Arrange
            var idCuonSach = 33;
            var daAn = 1;
            // Act
            bool result = dalCuonSach.UpdCuonSach(idCuonSach, daAn);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALCuonSach.Instance;
            var instance2 = DALCuonSach.Instance;

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
            var dalInstance = new DALCuonSach(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALCuonSach();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }
    }
}
