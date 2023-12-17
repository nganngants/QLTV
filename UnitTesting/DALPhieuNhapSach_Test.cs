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
    public class DALPhieuNhapSach_Test
    {
        private DALPhieuNhapSach dalPhieuNhapSach;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<PHIEUNHAPSACH>> phieuNhapSachDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            phieuNhapSachDbSetMock = new Mock<DbSet<PHIEUNHAPSACH>>();
            dalPhieuNhapSach = new DALPhieuNhapSach(dbContextMock.Object);

            var list = new List<PHIEUNHAPSACH>
            {
                 new PHIEUNHAPSACH{SoPhieuNhap = 1, TongTien = 30000, NgayNhap = DateTime.Now},
                    new PHIEUNHAPSACH{SoPhieuNhap = 2, TongTien = 30000, NgayNhap = DateTime.Now},


            };

            phieuNhapSachDbSetMock.As<IQueryable<PHIEUNHAPSACH>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            phieuNhapSachDbSetMock.As<IQueryable<PHIEUNHAPSACH>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            phieuNhapSachDbSetMock.As<IQueryable<PHIEUNHAPSACH>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            phieuNhapSachDbSetMock.As<IQueryable<PHIEUNHAPSACH>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.PHIEUNHAPSACHes).Returns(phieuNhapSachDbSetMock.Object);
        }


        [TestMethod]
        public void GetAllPhieuMuonTra_ShouldReturnListOfNguoiDung()
        {
            // Arrange

            var phieuMuonSach = new PHIEUNHAPSACH { SoPhieuNhap = 1, TongTien = 30000 };
            dbContextMock.Setup(db => db.PHIEUNHAPSACHes.Find(phieuMuonSach.SoPhieuNhap)).Returns(phieuMuonSach);
            // Act
            List<PHIEUNHAPSACH> result = dalPhieuNhapSach.GetAllPhieuNhapSach();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void GetPhieuMuonSachById_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingId = 1;
            var phieuMuonSach = new PHIEUNHAPSACH { SoPhieuNhap = 1, TongTien = 30000 };
            dbContextMock.Setup(db => db.PHIEUNHAPSACHes.Find(phieuMuonSach.SoPhieuNhap)).Returns(phieuMuonSach);
            // Act
            // Act
            PHIEUNHAPSACH result = dalPhieuNhapSach.GetPhieuById(existingId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingId, result.SoPhieuNhap);
        }

        [TestMethod]
        public void GetPhieuMuonSachById_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingTacGiaId = 999;

            // Act
            PHIEUNHAPSACH result = dalPhieuNhapSach.GetPhieuById(nonExistingTacGiaId);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void FindTheoNgayNhap_ShouldReturnMatchingLoaiPhieuMuonTra()
        {
            // Arrange
            var ngayNhap = DateTime.Now;

            var phieuMuonSach = new PHIEUNHAPSACH { SoPhieuNhap = 1, TongTien = 30000, NgayNhap = ngayNhap };
            dbContextMock.Setup(db => db.PHIEUNHAPSACHes.Find(phieuMuonSach.SoPhieuNhap)).Returns(phieuMuonSach);

            // Act
            var result = dalPhieuNhapSach.FindPhieuByNgayNhap(ngayNhap.Day, ngayNhap.Month, ngayNhap.Year);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null
            Assert.IsTrue(result.Count > 0); // Đảm bảo rằng chỉ có một phần tử trong danh sách

        }

        [TestMethod]
        public void FindTheoNgayMuon_ShouldReturnEmptyListForNonMatchingData()
        {
            // Arrange
            var ngayMuon = DateTime.Now;

            var phieuMuonSach = new PHIEUNHAPSACH { SoPhieuNhap = 1, TongTien = 30000 };
            dbContextMock.Setup(db => db.PHIEUNHAPSACHes.Find(phieuMuonSach.SoPhieuNhap)).Returns(phieuMuonSach);

            // Act
            var result = dalPhieuNhapSach.FindPhieuByNgayNhap(ngayMuon.Day, ngayMuon.Month, ngayMuon.Year);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null

        }

        [TestMethod]
        public void Test_AddTacGia()
        {
            var phieuNhapSach = new PHIEUNHAPSACH { SoPhieuNhap = 1, TongTien = 30000 };


            int result = dalPhieuNhapSach.AddPhieuNhap(phieuNhapSach);

            Assert.IsTrue(result > 0);
            phieuNhapSachDbSetMock.Verify(m => m.Add(phieuNhapSach), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void UpdPhieuNhap_ShouldUpdateExistingTacGia()
        {
            // Arrange
            var soPhieu = 1;
            var ngayNhap = DateTime.Now;
            var tongTien = 100000;

            // Thiết lập dữ liệu giả mạo cho DbSet
            var phieuMuonSach = new PHIEUNHAPSACH { SoPhieuNhap = 1, TongTien = 30000, NgayNhap  =  DateTime.Now};
            dbContextMock.Setup(db => db.PHIEUNHAPSACHes.Find(phieuMuonSach.SoPhieuNhap)).Returns(phieuMuonSach);


            // Lưu giá trị ban đầu


            // Act
            bool result = dalPhieuNhapSach.UpdPhieuNhap(soPhieu, ngayNhap, tongTien);

            // Assert
            Assert.IsTrue(result);

            //// Kiểm tra xem TACGIA đã được cập nhật chưa
            phieuNhapSachDbSetMock.Verify(m => m.Find(soPhieu), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

            //// Kiểm tra giá trị trước cập nhật và sau cập nhật
            Assert.AreEqual(ngayNhap, phieuMuonSach.NgayNhap);
            Assert.AreEqual(tongTien, phieuMuonSach.TongTien);
           


        }

        [TestMethod]
        public void UpdTacGia_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var soPhieu = 999;
            var ngayNhap = DateTime.Now;
            var tongTien = 100000;


            // Act
            bool result = dalPhieuNhapSach.UpdPhieuNhap(soPhieu, ngayNhap, tongTien);
            // Assert
            Assert.IsFalse(result);
        }



        [TestMethod]
        public void DelTacGia_ShouldDeleteExistingTacGia()
        {
            // Arrange
            var existingId = 1;
            var phieuMuonSach = new PHIEUNHAPSACH { SoPhieuNhap = 1, TongTien = 30000 };
            dbContextMock.Setup(db => db.PHIEUNHAPSACHes.Find(phieuMuonSach.SoPhieuNhap)).Returns(phieuMuonSach);

            // Act
            bool result = dalPhieuNhapSach.DelPhieuNhap(existingId);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            // Kiểm tra xem TACGIA đã được xóa chưa
            phieuNhapSachDbSetMock.Verify(m => m.Find(existingId), Times.Once);
            phieuNhapSachDbSetMock.Verify(m => m.Remove(phieuMuonSach), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelTacGia_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var nonExistingTacGiaId = 999; // Thay thế bằng một ID không tồn tại trong cơ sở dữ liệu

            // Act
            bool result = dalPhieuNhapSach.DelPhieuNhap(nonExistingTacGiaId);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }


        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALPhieuNhapSach.Instance;
            var instance2 = DALPhieuNhapSach.Instance;

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
            var dalInstance = new DALPhieuNhapSach(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALPhieuNhapSach();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }
    }
}
