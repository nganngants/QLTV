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
    public class DALBCSachTraTre_Test
    {

        private DALBCSachTraTre dalBCSachTraTre;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<BCSACHTRATRE>> bcSachTraTreDbSetMock;
     

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            bcSachTraTreDbSetMock = new Mock<DbSet<BCSACHTRATRE>>();
            dalBCSachTraTre = new DALBCSachTraTre(dbContextMock.Object);

            var list = new List<BCSACHTRATRE>
            {
                new BCSACHTRATRE{Ngay = DateTime.Now, idCuonSach = 1, NgayMuon = DateTime.Now, SoNgayTre = 3},
                new BCSACHTRATRE{Ngay = DateTime.Now, idCuonSach = 2, NgayMuon = DateTime.Now, SoNgayTre = 4},

            };

            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.BCSACHTRATREs).Returns(bcSachTraTreDbSetMock.Object);
        }

        [TestMethod]
        public void GetAllBCSachTraTre_ShouldReturnListOfBaoCao()
        {
            // Arrange

            var baocao = new BCSACHTRATRE { Ngay = DateTime.Now, idCuonSach = 1, NgayMuon = DateTime.Now, SoNgayTre = 3 };
            dbContextMock.Setup(db => db.BCSACHTRATREs.Find(baocao.idCuonSach)).Returns(baocao);
            // Act
            List<BCSACHTRATRE> result = dalBCSachTraTre.GetAllBaoCao();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void FindBaoCaoByDate_ShouldReturnListOfBaoCao()
        {
            // Arrange

            var existingngayBC = DateTime.Now;
            var baocao = new BCSACHTRATRE { Ngay = DateTime.Now, idCuonSach = 1, NgayMuon = DateTime.Now, SoNgayTre = 3 };
            dbContextMock.Setup(db => db.BCSACHTRATREs.Find(baocao.idCuonSach)).Returns(baocao);

            // Act
            List<BCSACHTRATRE> result = dalBCSachTraTre.FindBaoCaoByDate(existingngayBC);

            // Assert
            Assert.IsNotNull(result);


            Assert.IsTrue(result.Count > 0);


           
        }


        [TestMethod]
        public void FindBaoCaoCuonSach_ShouldReturnListOfBaoCao()
        {
            // Arrange

            var existingCuonSach = 1;
            var baocao = new BCSACHTRATRE { Ngay = DateTime.Now, idCuonSach = 1, NgayMuon = DateTime.Now, SoNgayTre = 3 };
            var data = new List<BCSACHTRATRE> { baocao };
            var mockData = data.AsQueryable();
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.Provider).Returns(mockData.Provider);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.Expression).Returns(mockData.Expression);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());


            // Act
            List<BCSACHTRATRE> result = dalBCSachTraTre.FindBaoCaoByCuonSach(existingCuonSach);

            // Assert
            Assert.IsNotNull(result);


            Assert.IsTrue(result.Count > 0);



        }

        [TestMethod]
        public void Test_AddBCSachTraTre()
        {
            var baocao = new BCSACHTRATRE { Ngay = DateTime.Now, idCuonSach = 1, NgayMuon = DateTime.Now, SoNgayTre = 3 };

            var cuonSach = new CUONSACH { id = 1 };
            dbContextMock.Setup(db => db.CUONSACHes.Find(cuonSach.id)).Returns(cuonSach);

            bool result = dalBCSachTraTre.AddBaoCao(baocao);

            Assert.IsTrue(result);
            dbContextMock.Verify(m => m.BCSACHTRATREs.Add(baocao), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelBaoCao_ShouldDeleteExistingBaoCao()
        {
            // Arrange
            var ngay = DateTime.Now;
            var idCuonSach = 1;

            // Thiết lập dữ liệu giả mạo cho DbSet
            var baocao = new BCSACHTRATRE { Ngay = ngay, idCuonSach = idCuonSach, NgayMuon = DateTime.Now, SoNgayTre = 3 };
            var data = new List<BCSACHTRATRE> { baocao };
            var mockData = data.AsQueryable();
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.Provider).Returns(mockData.Provider);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.Expression).Returns(mockData.Expression);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());


            // Act
            bool result = dalBCSachTraTre.DelBaoCao(ngay, idCuonSach);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công
    
            bcSachTraTreDbSetMock.Verify(m => m.Remove(baocao), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

        }

        [TestMethod]
        public void DelBaoCao_ShouldReturnFalseForNonExistingBaoCao()
        {
            // Arrange
            var ngay = DateTime.Now;
            var idCuonSach = 999;

            // Act
            bool result = dalBCSachTraTre.DelBaoCao(ngay, idCuonSach);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }

        [TestMethod]
        public void GetBaoCao_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            // Arrange
            var ngay = new DateTime(2024, 12, 10);
            var idCuonSach = 1;

            // Thiết lập dữ liệu giả mạo cho DbSet
            var baocao = new BCSACHTRATRE { Ngay = new DateTime(2024, 12, 10), idCuonSach = 1, NgayMuon = DateTime.Now, SoNgayTre = 3 };
            var data = new List<BCSACHTRATRE> { baocao };
            var mockData = data.AsQueryable();
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.Provider).Returns(mockData.Provider);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.Expression).Returns(mockData.Expression);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());


            // Act
            var result = dalBCSachTraTre.GetBaoCao(ngay, idCuonSach);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(ngay, result.Ngay);
            Assert.AreEqual(idCuonSach, result.idCuonSach);
        }


        [TestMethod]
        public void GetBaoCaoA_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            // Arrange
            var ngay = new DateTime(2024, 12, 10);
            var idCuonSach = 1;

            // Thiết lập dữ liệu giả mạo cho DbSet
            var baocao = new BCSACHTRATRE { Ngay = ngay, idCuonSach = 1, NgayMuon = DateTime.Now, SoNgayTre = 3 };
            var data = new List<BCSACHTRATRE> { baocao };
            var mockData = data.AsQueryable();
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.Provider).Returns(mockData.Provider);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.Expression).Returns(mockData.Expression);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            bcSachTraTreDbSetMock.As<IQueryable<BCSACHTRATRE>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());


            // Act
            var result = dalBCSachTraTre.GetBaoCao(ngay, idCuonSach);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(ngay, result.Ngay);
            Assert.AreEqual(idCuonSach, result.idCuonSach);

        }

        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALBCSachTraTre.Instance;
            var instance2 = DALBCSachTraTre.Instance;

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
            var dalInstance = new DALBCSachTraTre(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALBCSachTraTre();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }

        [TestMethod]
        public void DelBaoCao_ShouldReturnFalseOnException()
        {
            // Arrange
            var ngay = new DateTime(2024, 11, 11);
            var idCuonSach = 1;
            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<BCSACHTRATRE>();

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();
        
            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALBCSachTraTre(dbContextMock.Object);

            // Act
            var result = sut.DelBaoCao(ngay, idCuonSach);

            // Assert
            Assert.IsFalse(result);
        }

    }
}
