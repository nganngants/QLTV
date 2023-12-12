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
    public class DALPhieuMuonTra_Test
    {
        private DALPhieuMuonTra dalPhieuMuonTra;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<PHIEUMUONTRA>> phieuMuonTraDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            phieuMuonTraDbSetMock = new Mock<DbSet<PHIEUMUONTRA>>();
            dalPhieuMuonTra = new DALPhieuMuonTra(dbContextMock.Object);

            var list = new List<PHIEUMUONTRA>
            {
                new PHIEUMUONTRA{SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = DateTime.Now},
                new PHIEUMUONTRA{SoPhieuMuonTra = 2, idDocGia = 2, idCuonSach = 2, NgayMuon = DateTime.Now},


            };

            phieuMuonTraDbSetMock.As<IQueryable<PHIEUMUONTRA>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            phieuMuonTraDbSetMock.As<IQueryable<PHIEUMUONTRA>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            phieuMuonTraDbSetMock.As<IQueryable<PHIEUMUONTRA>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            phieuMuonTraDbSetMock.As<IQueryable<PHIEUMUONTRA>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.PHIEUMUONTRAs).Returns(phieuMuonTraDbSetMock.Object);
        }

        [TestMethod]
        public void GetAllPhieuMuonTra_ShouldReturnListOfNguoiDung()
        {
            // Arrange

            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1 };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);
            // Act
            List<PHIEUMUONTRA> result = dalPhieuMuonTra.GetAllPhieuMuonTra();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void GetPhieuMuonTraById_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingPhieuMuonTraId = 1;
            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1 };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);
            // Act
            PHIEUMUONTRA result = dalPhieuMuonTra.GetPhieuMuonTraById(existingPhieuMuonTraId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingPhieuMuonTraId, result.SoPhieuMuonTra);
        }

        [TestMethod]
        public void GetPhieuMuonTraById_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingTacGiaId = 999;

            // Act
            PHIEUMUONTRA result = dalPhieuMuonTra.GetPhieuMuonTraById(nonExistingTacGiaId);

            // Assert
            Assert.IsNull(result);      
        }

        [TestMethod]
        public void FindTheoNgayMuon_ShouldReturnMatchingLoaiPhieuMuonTra()
        {
            // Arrange
            var ngayMuon = DateTime.Now;

            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = ngayMuon };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);

            // Act
            var result = dalPhieuMuonTra.FindTheoNgayMuon(ngayMuon.Day, ngayMuon.Month, ngayMuon.Year);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null
            Assert.IsTrue(result.Count > 0); // Đảm bảo rằng chỉ có một phần tử trong danh sách

        }

        [TestMethod]
        public void FindTheoNgayMuon_ShouldReturnEmptyListForNonMatchingData()
        {
            // Arrange
            var ngayMuon = DateTime.Now;

            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = new DateTime(2024, 12, 9, 14, 30, 0) };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);

            // Act
            var result = dalPhieuMuonTra.FindTheoNgayMuon(ngayMuon.Day, ngayMuon.Month, ngayMuon.Year);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null
           
        }

        [TestMethod]
        public void FindTheoNgayTra_ShouldReturnMatchingLoaiPhieuMuonTra()
        {
            // Arrange
            var ngayMuon = DateTime.Now;

            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = ngayMuon };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);

            // Act
            var result = dalPhieuMuonTra.FindTheoNgayTra(ngayMuon.Day, ngayMuon.Month, ngayMuon.Year);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null
            

        }

        [TestMethod]
        public void FindTheoNgayTra_ShouldReturnEmptyListForNonMatchingData()
        {
            // Arrange
            var ngayMuon = DateTime.Now;

            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = new DateTime(2024, 12, 9, 14, 30, 0) };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);

            // Act
            var result = dalPhieuMuonTra.FindTheoNgayTra(ngayMuon.Day, ngayMuon.Month, ngayMuon.Year);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null

        }

        [TestMethod]
        public void FindPhieuMuonTra_ShouldReturnMatchingLoaiPhieuMuonTra()
        {
            // Arrange
            var ngayMuon = DateTime.Now;

            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = ngayMuon };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);

            // Act
            var result = dalPhieuMuonTra.FindPhieuMuonTre(ngayMuon);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null


        }

        [TestMethod]
        public void FindPhieuMuonTra_ShouldReturnEmptyListForNonMatchingData()
        {
            // Arrange
            var ngayMuon = DateTime.Now;

            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = new DateTime(2024, 12, 9, 14, 30, 0) };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);

            // Act
            var result = dalPhieuMuonTra.FindPhieuMuonTre(ngayMuon);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null

        }

        [TestMethod]
        public void FindByDocGia_ShouldReturnMatchingLoaiPhieuMuonTra()
        {
            // Arrange
            var idDocGia = 1;

            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = DateTime.Now };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);

            // Act
            var result = dalPhieuMuonTra.FindPhieuMuonByDocGia(idDocGia);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null


        }

        [TestMethod]
        public void FindByDocGia_ShouldReturnEmptyListForNonMatchingData()
        {
            // Arrange
            var idDocGia = 1;

            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = new DateTime(2024, 12, 9, 14, 30, 0) };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);

            // Act
            var result = dalPhieuMuonTra.FindPhieuMuonByDocGia(idDocGia);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null

        }

        [TestMethod]
        public void Test_AddTacGia()
        {
            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = new DateTime(2024, 12, 9, 14, 30, 0) };


            bool result = dalPhieuMuonTra.AddPhieuMuonTra(phieuMuonTra);

            Assert.IsTrue(result);
            dbContextMock.Verify(m => m.PHIEUMUONTRAs.Add(phieuMuonTra), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void UpdTacGia_ShouldUpdateExistingTacGia()
        {
            // Arrange
            var soPhieu = 1;
            var ngayMuon = DateTime.Now;
            var hanTra = DateTime.Now;
            var ngayTra = DateTime.Now;
            var soTienPhat = 10000;

            // Thiết lập dữ liệu giả mạo cho DbSet
            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = new DateTime(2024, 12, 9, 14, 30, 0) };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);


            // Lưu giá trị ban đầu
           

            // Act
            bool result = dalPhieuMuonTra.UpdPhieuMuonTra(soPhieu, ngayMuon, hanTra, ngayTra, soTienPhat);

            // Assert
            Assert.IsTrue(result);

            //// Kiểm tra xem TACGIA đã được cập nhật chưa
            phieuMuonTraDbSetMock.Verify(m => m.Find(soPhieu), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

            //// Kiểm tra giá trị trước cập nhật và sau cập nhật
            Assert.AreEqual(ngayMuon, phieuMuonTra.NgayMuon);
            Assert.AreEqual(hanTra, phieuMuonTra.HanTra);
            Assert.AreEqual(ngayTra, phieuMuonTra.NgayTra);
            Assert.AreEqual(soTienPhat, phieuMuonTra.SoTienPhat);


        }

        [TestMethod]
        public void UpdTacGia_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var soPhieu = 999;
            var ngayMuon = DateTime.Now;
            var hanTra = DateTime.Now;
            var ngayTra = DateTime.Now;
            var soTienPhat = 10000;

            // Act
            bool result = dalPhieuMuonTra.UpdPhieuMuonTra(soPhieu, ngayMuon, hanTra, ngayTra, soTienPhat);
            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void DelTacGia_ShouldDeleteExistingTacGia()
        {
            // Arrange
            var soPhieu = 1; // Thay thế bằng ID của một TACGIA tồn tại trong cơ sở dữ liệu

            // Thiết lập dữ liệu giả mạo cho DbSet
            var phieuMuonTra = new PHIEUMUONTRA { SoPhieuMuonTra = 1, idDocGia = 1, idCuonSach = 1, NgayMuon = new DateTime(2024, 12, 9, 14, 30, 0) };
            dbContextMock.Setup(db => db.PHIEUMUONTRAs.Find(phieuMuonTra.SoPhieuMuonTra)).Returns(phieuMuonTra);


            // Act
            bool result = dalPhieuMuonTra.DelPhieuMuonTra(soPhieu);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            // Kiểm tra xem TACGIA đã được xóa chưa
            phieuMuonTraDbSetMock.Verify(m => m.Find(soPhieu), Times.Once);
            phieuMuonTraDbSetMock.Verify(m => m.Remove(phieuMuonTra), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelTacGia_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var nonExistingTacGiaId = 999; // Thay thế bằng một ID không tồn tại trong cơ sở dữ liệu

            // Act
            bool result = dalPhieuMuonTra.DelPhieuMuonTra(nonExistingTacGiaId);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }
        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALPhieuMuonTra.Instance;
            var instance2 = DALPhieuMuonTra.Instance;

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
            var dalInstance = new DALPhieuMuonTra(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALPhieuMuonTra();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }

        [TestMethod]
        public void UpdPhieuMuonTra_ShouldReturnFalseOnException()
        {
            // Arrange
            var soPhieu = 99;
            var ngayMuon = DateTime.Now;
            var hanTra = DateTime.Now;
            var ngayTra = DateTime.Now;
            var soTienPhat = 30000;
            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<PHIEUMUONTRA>();

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALPhieuMuonTra(dbContextMock.Object);

            // Act
            var result = sut.UpdPhieuMuonTra(soPhieu, ngayMuon, hanTra, ngayTra, soTienPhat);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DelPhieuMuonTra_ShouldReturnFalseOnException()
        {
            // Arrange
            var soPhieu = 99;
        
            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<PHIEUMUONTRA>();

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALPhieuMuonTra(dbContextMock.Object);

            // Act
            var result = sut.DelPhieuMuonTra(soPhieu);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
