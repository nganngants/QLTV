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
    public class DALPhieuThu_Test
    {
        private DALPhieuThu dalPhieuThu;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<PHIEUTHU>> phieuThuDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            phieuThuDbSetMock = new Mock<DbSet<PHIEUTHU>>();
            dalPhieuThu = new DALPhieuThu(dbContextMock.Object);

            var list = new List<PHIEUTHU>
            {
                 new PHIEUTHU {SoPhieuThu = 1, idDocGia = 1, SoTienThu = 50000, NgayLap = DateTime.Now},
                 new PHIEUTHU {SoPhieuThu = 2, idDocGia = 2, SoTienThu = 50000, NgayLap = DateTime.Now}

            };

            phieuThuDbSetMock.As<IQueryable<PHIEUTHU>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            phieuThuDbSetMock.As<IQueryable<PHIEUTHU>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            phieuThuDbSetMock.As<IQueryable<PHIEUTHU>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            phieuThuDbSetMock.As<IQueryable<PHIEUTHU>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.PHIEUTHUs).Returns(phieuThuDbSetMock.Object);
        }



        [TestMethod]
        public void GetAllPhieuThu_ShouldReturnListOfNguoiDung()
        {
            // Arrange

            var phieuThu = new PHIEUTHU { SoPhieuThu = 1, idDocGia = 1, SoTienThu = 50000 };
            dbContextMock.Setup(db => db.PHIEUTHUs.Find(phieuThu.SoPhieuThu)).Returns(phieuThu);
            // Act
            List<PHIEUTHU> result = dalPhieuThu.GetAllPhieuThu();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void GetPhieuThuById_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingId = 1;
            var phieuThu = new PHIEUTHU { SoPhieuThu = 1, idDocGia = 1, SoTienThu = 50000 };
            dbContextMock.Setup(db => db.PHIEUTHUs.Find(phieuThu.SoPhieuThu)).Returns(phieuThu);
            // Act
            PHIEUTHU result = dalPhieuThu.GetPhieuThuById(existingId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingId, result.SoPhieuThu);
        }

        [TestMethod]
        public void GetPhieuThuById_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingTacGiaId = 999;

            // Act
            PHIEUTHU result = dalPhieuThu.GetPhieuThuById(nonExistingTacGiaId);

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void FindTheoNgayNhap_ShouldReturnMatchingLoaiPhieuMuonTra()
        {
            // Arrange
            var ngayNhap = DateTime.Now;

            var phieuThu = new PHIEUTHU { SoPhieuThu = 1, idDocGia = 1, SoTienThu = 50000, NgayLap = ngayNhap };
            dbContextMock.Setup(db => db.PHIEUTHUs.Find(phieuThu.SoPhieuThu)).Returns(phieuThu);

            // Act
            var result = dalPhieuThu.FindPhieuThuByNgay(ngayNhap.Day, ngayNhap.Month, ngayNhap.Year);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null
            Assert.IsTrue(result.Count > 0); // Đảm bảo rằng chỉ có một phần tử trong danh sách

        }

        [TestMethod]
        public void FindTheoNgayMuon_ShouldReturnEmptyListForNonMatchingData()
        {
            // Arrange
            var ngayNhap = DateTime.Now;

            var phieuThu = new PHIEUTHU { SoPhieuThu = 1, idDocGia = 1, SoTienThu = 50000, NgayLap = new DateTime(2024, 12, 9, 14, 30, 0) };
            dbContextMock.Setup(db => db.PHIEUTHUs.Find(phieuThu.SoPhieuThu)).Returns(phieuThu);

            // Act
            var result = dalPhieuThu.FindPhieuThuByNgay(ngayNhap.Day, ngayNhap.Month, ngayNhap.Year);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null

        }

        [TestMethod]
        public void Test_AddPhieuThu()
        {
            var phieuThu = new PHIEUTHU { SoPhieuThu = 1, idDocGia = 1, SoTienThu = 50000, NgayLap = new DateTime(2024, 12, 9, 14, 30, 0) };


            bool result = dalPhieuThu.AddPhieuThu(phieuThu);

            Assert.IsTrue(result);
            phieuThuDbSetMock.Verify(m => m.Add(phieuThu), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void UpdPhieuNhap_ShouldUpdateExistingTacGia()
        {
            // Arrange
            var soPhieu = 1;
            var ngayLap = DateTime.Now;
            var soTien = 100000;

            var docGia = new DOCGIA { ID = 1, MaDocGia = "DG001", TongNoHienTai = 0 };
            dbContextMock.Setup(db => db.DOCGIAs.Find(docGia.ID)).Returns(docGia);

            // Thiết lập dữ liệu giả mạo cho DbSet
            var phieuThu = new PHIEUTHU { SoPhieuThu = 1, idDocGia = 1, SoTienThu = 50000, NgayLap = new DateTime(2024, 12, 9, 14, 30, 0), };
            dbContextMock.Setup(db => db.PHIEUTHUs.Find(phieuThu.SoPhieuThu)).Returns(phieuThu);


            // Lưu giá trị ban đầu


            // Act
            bool result = dalPhieuThu.UpdPhieuThu(soPhieu, soTien, ngayLap);

            // Assert
            Assert.IsTrue(result);

            //// Kiểm tra xem TACGIA đã được cập nhật chưa
            phieuThuDbSetMock.Verify(m => m.Find(soPhieu), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

            //// Kiểm tra giá trị trước cập nhật và sau cập nhật
            Assert.AreEqual(ngayLap, phieuThu.NgayLap);
         



        }

        [TestMethod]
        public void UpdTacGia_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var soPhieu = 999;
            var ngayLap = DateTime.Now;
            var soTien = 100000;


            // Act
            bool result = dalPhieuThu.UpdPhieuThu(soPhieu, soTien, ngayLap);
            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DelTacGia_ShouldDeleteExistingTacGia()
        {
            var existingId = 1;
            var phieuThu = new PHIEUTHU { SoPhieuThu = 1, idDocGia = 1, SoTienThu = 50000 };
            dbContextMock.Setup(db => db.PHIEUTHUs.Find(phieuThu.SoPhieuThu)).Returns(phieuThu);

            // Act
            bool result = dalPhieuThu.DelPhieuThu(existingId);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            // Kiểm tra xem TACGIA đã được xóa chưa
            phieuThuDbSetMock.Verify(m => m.Find(existingId), Times.Once);
            phieuThuDbSetMock.Verify(m => m.Remove(phieuThu), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelTacGia_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var nonExistingTacGiaId = 999; // Thay thế bằng một ID không tồn tại trong cơ sở dữ liệu

            // Act
            bool result = dalPhieuThu.DelPhieuThu(nonExistingTacGiaId);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }

        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALPhieuThu.Instance;
            var instance2 = DALPhieuThu.Instance;

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
            var dalInstance = new DALPhieuThu(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALPhieuThu();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }
    }
}
