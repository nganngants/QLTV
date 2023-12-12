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
    public class DALDocGia_Test
    {
        private DALDocGia dalDocGia;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<DOCGIA>> DocGiaDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            DocGiaDbSetMock = new Mock<DbSet<DOCGIA>>();
            dalDocGia = new DALDocGia(dbContextMock.Object);

            var list = new List<DOCGIA>
            {
                new DOCGIA{ID = 1, MaDocGia = "DG001", TenDocGia = "Nguyen Van A" ,   idNguoiDung = 1},
                new DOCGIA{ID = 2, MaDocGia = "DG001", TenDocGia = "Nguyen Van A" ,  idNguoiDung = 1}

            };

            DocGiaDbSetMock.As<IQueryable<DOCGIA>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            DocGiaDbSetMock.As<IQueryable<DOCGIA>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            DocGiaDbSetMock.As<IQueryable<DOCGIA>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            DocGiaDbSetMock.As<IQueryable<DOCGIA>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.DOCGIAs).Returns(DocGiaDbSetMock.Object);
        }

        [TestMethod]
        public void Test_AddDocGia()
        {
            var docGia = new DOCGIA { ID = 1, MaDocGia = "DG001", TenDocGia = "Nguyen Van A" };

            bool result = dalDocGia.AddDocGia(docGia);

            Assert.IsTrue(result);
            dbContextMock.Verify(m => m.DOCGIAs.Add(docGia), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetDocGiaById_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingDocGiaId = 1;
            var docGia = new DOCGIA { ID = 1, MaDocGia = "DG001", TenDocGia = "Nguyen Van A" };
            dbContextMock.Setup(db => db.DOCGIAs.Find(docGia.ID)).Returns(docGia);
            // Act
            DOCGIA result = dalDocGia.GetDocGiaById(existingDocGiaId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingDocGiaId, result.ID);
        }

        [TestMethod]
        public void GetDocGiaById_ShouldReturnNullForNonExistingDocGia()
        {
            // Arrange

            var nonExistingTacGiaId = 999;

            // Act
            DOCGIA result = dalDocGia.GetDocGiaById(nonExistingTacGiaId);

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void GetDocGiaByMa_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingMaDocGia = "DG001";
            var docGia = new DOCGIA { ID = 1, MaDocGia = "DG001", TenDocGia = "Nguyen Van A" };
            dbContextMock.Setup(db => db.DOCGIAs.Find(docGia.ID)).Returns(docGia);
            // Act
            DOCGIA result = dalDocGia.GetDocGiaByMa(existingMaDocGia);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingMaDocGia, result.MaDocGia);
        }

        [TestMethod]
        public void GetDocGiaByMa_ShouldReturnNullForNonExistingDocGia()
        {
            // Arrange

            var nonExistingMaTacGia = "NonExistingMaTacGia";

            // Act
            DOCGIA result = dalDocGia.GetDocGiaByMa(nonExistingMaTacGia);

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void GetAllDocGia_ShouldReturnListOfTacGia()
        {
            // Arrange

            var docGia = new DOCGIA { ID = 1, MaDocGia = "DG001", TenDocGia = "Nguyen Van A" };
            dbContextMock.Setup(db => db.DOCGIAs.Find(docGia.ID)).Returns(docGia);
            // Act
            List<DOCGIA> result = dalDocGia.GetAllDocGia();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void FindDocGiaByIdND_ShouldReturnDocGiaForExistingData()
        {
            // Arrange
            var idNguoiDung = 1; // Thay thế bằng một ID người dùng tồn tại trong cơ sở dữ liệu

            // Thiết lập dữ liệu giả mạo cho DbSet
            var docGia = new DOCGIA { ID = 1, MaDocGia = "DG001", TenDocGia = "Nguyen Van A", idNguoiDung = 1 };
            dbContextMock.Setup(db => db.DOCGIAs.Find(docGia.ID)).Returns(docGia);
            // Act
            var result = dalDocGia.FindDocGiaByIdND(idNguoiDung);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng hàm FindDocGiaByIdND trả về một đối tượng DOCGIA
            Assert.AreEqual(idNguoiDung, result.idNguoiDung); // Đảm bảo rằng ID người dùng của kết quả trả về đúng
        }

        [TestMethod]
        public void FindDocGiaByIdND_ShouldThrowExceptionForNonExistingData()
        {
            // Arrange
            var nonExistingIdNguoiDung = 999; // Thay thế bằng một ID người dùng không tồn tại trong cơ sở dữ liệu

            // Act
            var result = dalDocGia.FindDocGiaByIdND(nonExistingIdNguoiDung);

            Assert.IsNull(result);
        }

        [TestMethod]
        public void UpdDocGia_ShouldUpdateDocGiaWithNonNullValues()
        {
            // Arrange
            var idDocGia = 1; // Thay thế bằng một ID độc giả tồn tại trong cơ sở dữ liệu
            var tenDocGia = "New Ten Doc Gia";
            var ngaySinh = new DateTime(1990, 1, 1);
            var diaChi = "New Dia Chi";
            var email = "new.email@example.com";
            var ngayHetHan = new DateTime(2023, 12, 31);
            var idLoaiDocGia = 2; // Thay thế bằng một ID loại độc giả tồn tại trong cơ sở dữ liệu

            // Thiết lập dữ liệu giả mạo cho DbSet
            var existingDocGia = new DOCGIA { ID = 1, MaDocGia = "DG001", TenDocGia = "Nguyen Van A", idNguoiDung = 1 };
            dbContextMock.Setup(db => db.DOCGIAs.Find(existingDocGia.ID)).Returns(existingDocGia);
            // Act
            var result = dalDocGia.UpdDocGia(idDocGia, tenDocGia, ngaySinh, diaChi, email, ngayHetHan, idLoaiDocGia);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm UpdDocGia trả về true khi cập nhật thành công

            // Kiểm tra xem giá trị đã được cập nhật chưa
            Assert.AreEqual(tenDocGia, existingDocGia.TenDocGia);
            Assert.AreEqual(ngaySinh, existingDocGia.NgaySinh);
            Assert.AreEqual(diaChi, existingDocGia.DiaChi);
            Assert.AreEqual(email, existingDocGia.Email);
            Assert.AreEqual(ngayHetHan, existingDocGia.NgayHetHan);
            Assert.AreEqual(idLoaiDocGia, existingDocGia.idLoaiDocGia);

            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void UpdDocGia_ShouldNotUpdateDocGiaForNonExistingData()
        {
            // Arrange
            var nonExistingIdDocGia = 999; // Thay thế bằng một ID độc giả không tồn tại trong cơ sở dữ liệu

            // Act
            var result = dalDocGia.UpdDocGia(nonExistingIdDocGia, "New Ten Doc Gia", DateTime.Now, "New Dia Chi", "new.email@example.com", DateTime.Now, 1);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm UpdDocGia trả về false khi không tìm thấy dữ liệu
        }

        [TestMethod]
        public void UpdTongNoDocGia_ShouldUpdateTongNoForExistingData()
        {
            // Arrange
            var idDocGia = 1; // Thay thế bằng một ID độc giả tồn tại trong cơ sở dữ liệu
            var tongNoMoi = 50000; // Giả sử một giá trị mới cho tổng nợ

            // Thiết lập dữ liệu giả mạo cho DbSet
            var existingDocGia = new DOCGIA { ID = 1, MaDocGia = "DG001", TenDocGia = "Nguyen Van A", idNguoiDung = 1 };
            dbContextMock.Setup(db => db.DOCGIAs.Find(existingDocGia.ID)).Returns(existingDocGia);

            // Act
            var result = dalDocGia.UpdTongNoDocGia(idDocGia, tongNoMoi);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm UpdTongNoDocGia trả về true khi cập nhật thành công
            Assert.AreEqual(tongNoMoi, existingDocGia.TongNoHienTai); // Đảm bảo rằng tổng nợ của độc giả đã được cập nhật
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void UpdTongNoDocGia_ShouldNotUpdateTongNoForNonExistingData()
        {
            // Arrange
            var nonExistingIdDocGia = 999; // Thay thế bằng một ID độc giả không tồn tại trong cơ sở dữ liệu
            var tongNoMoi = 50000; // Giả sử một giá trị mới cho tổng nợ

            // Act
            var result = dalDocGia.UpdTongNoDocGia(nonExistingIdDocGia, tongNoMoi);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm UpdTongNoDocGia trả về false khi không tìm thấy dữ liệu
        }

        [TestMethod]
        public void DelDocGia_ShouldDeleteExistingDocGia()
        {
            // Arrange
            var existingDocGiaId = 1; // Thay thế bằng ID của một TACGIA tồn tại trong cơ sở dữ liệu

            // Thiết lập dữ liệu giả mạo cho DbSet
            var existingDocGia = new DOCGIA { ID = 1, MaDocGia = "DG001", TenDocGia = "Nguyen Van A", idNguoiDung = 1 };
            dbContextMock.Setup(db => db.DOCGIAs.Find(existingDocGia.ID)).Returns(existingDocGia);

            // Act
            bool result = dalDocGia.DelDocGia(existingDocGiaId);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            // Kiểm tra xem TACGIA đã được xóa chưa
            DocGiaDbSetMock.Verify(m => m.Find(existingDocGiaId), Times.Once);
            DocGiaDbSetMock.Verify(m => m.Remove(existingDocGia), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelDocGia_ShouldReturnFalseForNonExistingDocGia()
        {
            // Arrange
            var nonExistingTacGiaId = 999; // Thay thế bằng một ID không tồn tại trong cơ sở dữ liệu

            // Act
            bool result = dalDocGia.DelDocGia(nonExistingTacGiaId);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }


        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALDocGia.Instance;
            var instance2 = DALDocGia.Instance;

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
            var dalInstance = new DALDocGia(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALDocGia();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }
    }
}
