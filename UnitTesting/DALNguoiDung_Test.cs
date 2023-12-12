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
    public class DALNguoiDung_Test
    {
        private DALNguoiDung dalNguoiDung;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<NGUOIDUNG>> NguoiDungDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            NguoiDungDbSetMock = new Mock<DbSet<NGUOIDUNG>>();
            dalNguoiDung = new DALNguoiDung(dbContextMock.Object);

            var list = new List<NGUOIDUNG>
            {
                new NGUOIDUNG{id = 1, MaNguoiDung = "ND001", TenNguoiDung = "Nguyen Van A", TenDangNhap = "NguyenVanA"},
                new NGUOIDUNG{id = 2, MaNguoiDung = "ND002", TenNguoiDung = "Nguyen Van B", TenDangNhap = "NguyenVanB"},

            };

            NguoiDungDbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            NguoiDungDbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            NguoiDungDbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            NguoiDungDbSetMock.As<IQueryable<NGUOIDUNG>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.NGUOIDUNGs).Returns(NguoiDungDbSetMock.Object);
        }

        [TestMethod]
        public void GetAllNguoiDung_ShouldReturnListOfNguoiDung()
        {
            // Arrange

            var nguoiDung = new NGUOIDUNG { id = 1, MaNguoiDung = "ND001", TenNguoiDung = "Nguyen Van A", TenDangNhap = "NguyenVanA" };
            dbContextMock.Setup(db => db.NGUOIDUNGs.Find(nguoiDung.id)).Returns(nguoiDung);
            // Act
            List<NGUOIDUNG> result = dalNguoiDung.GetAllNguoiDung();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void GetNguoiDungById_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingNguoiDungId = 1;
            var nguoiDung = new NGUOIDUNG { id = 1, MaNguoiDung = "ND001", TenNguoiDung = "Nguyen Van A", TenDangNhap = "NguyenVanA" };
            dbContextMock.Setup(db => db.NGUOIDUNGs.Find(nguoiDung.id)).Returns(nguoiDung);
            // Act
            NGUOIDUNG result = dalNguoiDung.GetNguoiDungById(existingNguoiDungId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingNguoiDungId, result.id);
        }

        [TestMethod]
        public void GetNguoiDungById_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingTacGiaId = 999;

            // Act
            NGUOIDUNG result = dalNguoiDung.GetNguoiDungById(nonExistingTacGiaId);

            // Assert
            Assert.IsNull(result);
        }



        [TestMethod]
        public void GetNguoiDungByMa_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingMaNguoiDung = "ND001";
            var nguoiDung = new NGUOIDUNG { id = 1, MaNguoiDung = "ND001", TenNguoiDung = "Nguyen Van A", TenDangNhap = "NguyenVanA" };
            dbContextMock.Setup(db => db.NGUOIDUNGs.Find(nguoiDung.id)).Returns(nguoiDung);
            NGUOIDUNG result = dalNguoiDung.GetNguoiDungByMa(existingMaNguoiDung);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingMaNguoiDung, result.MaNguoiDung);
        }

        [TestMethod]
        public void GetNguoiDungByMa_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingMaTacGia = "NonExistingMaTacGia";

            // Act
            NGUOIDUNG result = dalNguoiDung.GetNguoiDungByMa(nonExistingMaTacGia);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetNguoiDungByUsername_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingUsername = "NguyenVanA";
            var nguoiDung = new NGUOIDUNG { id = 1, MaNguoiDung = "ND001", TenNguoiDung = "Nguyen Van A" , TenDangNhap = "NguyenVanA" };
            dbContextMock.Setup(db => db.NGUOIDUNGs.Find(nguoiDung.id)).Returns(nguoiDung);
            NGUOIDUNG result = dalNguoiDung.GetNguoiDungByUsername(existingUsername);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingUsername, result.TenDangNhap);
        }

        [TestMethod]
        public void GetNguoiDungByUsername_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingMaTacGia = "NonExistingMaTacGia";

            // Act
            NGUOIDUNG result = dalNguoiDung.GetNguoiDungByUsername(nonExistingMaTacGia);

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void Test_AddNguoiDung()
        {
            var nguoiDung = new NGUOIDUNG { id = 1, MaNguoiDung = "ND001", TenNguoiDung = "Nguyen Van A", TenDangNhap = "NguyenVanA" };

            int result = dalNguoiDung.AddNguoiDung(nguoiDung);

            Assert.IsTrue(result > 0);
            NguoiDungDbSetMock.Verify(m => m.Add(nguoiDung), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void UpdNguoiDung_ShouldUpdateDocGiaWithNonNullValues()
        {
            // Arrange
            var idNguoiDung = 1; // Thay thế bằng một ID độc giả tồn tại trong cơ sở dữ liệu
            var tenNguoiDung = "Nguyen Van C";
            var ngaySinh = new DateTime(1990, 1, 1);
            var ChucVu = "Truong Phong";
            var idNhomNguoiDung = 1;


            // Thiết lập dữ liệu giả mạo cho DbSet
            var nguoiDung = new NGUOIDUNG { id = 1, MaNguoiDung = "ND001", TenNguoiDung = "Nguyen Van A", TenDangNhap = "NguyenVanA" };
            dbContextMock.Setup(db => db.NGUOIDUNGs.Find(nguoiDung.id)).Returns(nguoiDung);
            // Act
            var result = dalNguoiDung.UpdNguoiDung(idNguoiDung, tenNguoiDung, ngaySinh, ChucVu, idNhomNguoiDung);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm UpdDocGia trả về true khi cập nhật thành công

            // Kiểm tra xem giá trị đã được cập nhật chưa
            Assert.AreEqual(tenNguoiDung, nguoiDung.TenNguoiDung);
            Assert.AreEqual(ngaySinh, nguoiDung.NgaySinh);
            Assert.AreEqual(ChucVu, nguoiDung.ChucVu);
            Assert.AreEqual(idNhomNguoiDung, nguoiDung.idNhomNguoiDung);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void UpdNguoiDung_ShouldNotUpdateDocGiaForNonExistingData()
        {
            // Arrange
            var nonExistingIdNguoiDung = 999; // Thay thế bằng một ID độc giả không tồn tại trong cơ sở dữ liệu

            // Act
            var result = dalNguoiDung.UpdNguoiDung(nonExistingIdNguoiDung, "Nguyen Van C", DateTime.Now, "TruongPhong", 3);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm UpdDocGia trả về false khi không tìm thấy dữ liệu
        }


        [TestMethod]
        public void UpdPasswordNguoiDung_ShouldUpdateTongNoForExistingData()
        {
            // Arrange
            var idNguoiDung = 1; // Thay thế bằng một ID độc giả tồn tại trong cơ sở dữ liệu
            var password = "123466532"; // Giả sử một giá trị mới cho tổng nợ

            // Thiết lập dữ liệu giả mạo cho DbSet
            var nguoiDung = new NGUOIDUNG { id = 1, MaNguoiDung = "ND001", TenNguoiDung = "Nguyen Van A", TenDangNhap = "NguyenVanA" };
            dbContextMock.Setup(db => db.NGUOIDUNGs.Find(nguoiDung.id)).Returns(nguoiDung);

            // Act
            var result = dalNguoiDung.UpdPassword(idNguoiDung, password);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm UpdTongNoDocGia trả về true khi cập nhật thành công
            Assert.AreEqual(password, nguoiDung.MatKhau); // Đảm bảo rằng tổng nợ của độc giả đã được cập nhật
        }

        [TestMethod]
        public void UpdasswordNguoiDung_ShouldNotUpdateTongNoForNonExistingData()
        {
            // Arrange
            var nonExistingIdNguoiDung = 999; // Thay thế bằng một ID độc giả không tồn tại trong cơ sở dữ liệu
            var password = "123466532";// Giả sử một giá trị mới cho tổng nợ

            // Act
            var result = dalNguoiDung.UpdPassword(nonExistingIdNguoiDung, password);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm UpdTongNoDocGia trả về false khi không tìm thấy dữ liệu
        }



        [TestMethod]
        public void DelNguoiDung_ShouldDeleteExistingNguoiDung()
        {
            // Arrange
            var existingNguoiDungId = 1; // Thay thế bằng ID của một TACGIA tồn tại trong cơ sở dữ liệu

            // Thiết lập dữ liệu giả mạo cho DbSet
            var nguoiDung = new NGUOIDUNG { id = 1, MaNguoiDung = "ND001", TenNguoiDung = "Nguyen Van A", TenDangNhap = "NguyenVanA" };
            dbContextMock.Setup(db => db.NGUOIDUNGs.Find(nguoiDung.id)).Returns(nguoiDung);

            // Act
            bool result = dalNguoiDung.DelNguoiDung(existingNguoiDungId);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            // Kiểm tra xem TACGIA đã được xóa chưa
            NguoiDungDbSetMock.Verify(m => m.Find(existingNguoiDungId), Times.Once);
            NguoiDungDbSetMock.Verify(m => m.Remove(nguoiDung), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelNguoiDung_ShouldReturnFalseForNonExistingNguoiDung()
        {
            // Arrange
            var nonExistingTacGiaId = 999; // Thay thế bằng một ID không tồn tại trong cơ sở dữ liệu

            // Act
            bool result = dalNguoiDung.DelNguoiDung(nonExistingTacGiaId);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }


        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALNguoiDung.Instance;
            var instance2 = DALNguoiDung.Instance;

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
            var dalInstance = new DALNguoiDung(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALNguoiDung();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }
    }
}
