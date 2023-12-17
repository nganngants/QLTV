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
    public class DALChucNang_Test
    {
        private DALChucNang dalChucNang;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<CHUCNANG>> chucNangDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            chucNangDbSetMock = new Mock<DbSet<CHUCNANG>>();
            dalChucNang = new DALChucNang(dbContextMock.Object);

            var list = new List<CHUCNANG>
            {
              new CHUCNANG { id  = 1, MaChucNang = "CN001", TenChucNang = "Kiem Thu", TenManHinh = "Login" },
              new CHUCNANG { id  = 2, MaChucNang = "CN001", TenChucNang = "Kiem Thu", TenManHinh = "Login" }
           
            };

            chucNangDbSetMock.As<IQueryable<CHUCNANG>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            chucNangDbSetMock.As<IQueryable<CHUCNANG>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            chucNangDbSetMock.As<IQueryable<CHUCNANG>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            chucNangDbSetMock.As<IQueryable<CHUCNANG>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.CHUCNANGs).Returns(chucNangDbSetMock.Object);
        }

        [TestMethod]
        public void GetAllChucNang_ShouldReturnListOfChucNang()
        {
            // Arrange

            var chucnang = new CHUCNANG { id  = 1, MaChucNang = "CN001", TenChucNang = "Kiem Thu", TenManHinh = "Login" };
            dbContextMock.Setup(db => db.CHUCNANGs.Find(chucnang.id)).Returns(chucnang);
            // Act
            List<CHUCNANG> result = dalChucNang.GetAllChucNang();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void GetChucNangByMa_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingMaChucNang = "CN001";
            var chucnang = new CHUCNANG { id  = 1, MaChucNang = "CN001", TenChucNang = "Kiem Thu", TenManHinh = "Login" };
            dbContextMock.Setup(db => db.CHUCNANGs.Find(chucnang.id)).Returns(chucnang);
            // Act
            CHUCNANG result = dalChucNang.GetChucNangByMa(existingMaChucNang);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingMaChucNang, result.MaChucNang);
        }

        [TestMethod]
        public void GetChucNangByMa_ShouldReturnNullForNonExistingChucNang()
        {
            // Arrange

            var nonExistingMaTacGia = "NonExistingMaTacGia";

            // Act
            CHUCNANG result = dalChucNang.GetChucNangByMa(nonExistingMaTacGia);

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void GetChucNangByID_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var id = 1;
            var chucnang = new CHUCNANG { id  = 1, MaChucNang = "CN001", TenChucNang = "Kiem Thu", TenManHinh = "Login" };
            dbContextMock.Setup(db => db.CHUCNANGs.Find(chucnang.id)).Returns(chucnang);
            // Act
            CHUCNANG result = dalChucNang.GetChucNangById(id);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(id, result.id);
        }

        [TestMethod]
        public void GetChucNangByID_ShouldReturnNullForNonExistingChucNang()
        {
            // Arrange

            var id = 999;

            // Act
            CHUCNANG result = dalChucNang.GetChucNangById(id);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALChucNang.Instance;
            var instance2 = DALChucNang.Instance;

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
            var dalInstance = new DALChucNang(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALChucNang();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }

    }
}
