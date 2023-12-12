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
    public class DALNhomNguoiDung_Test
    {
        private DALNhomNguoiDung dalNhomNguoiDung;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<NHOMNGUOIDUNG>> NhomNguoiDungDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            NhomNguoiDungDbSetMock = new Mock<DbSet<NHOMNGUOIDUNG>>();
            dalNhomNguoiDung = new DALNhomNguoiDung(dbContextMock.Object);

            var list = new List<NHOMNGUOIDUNG>
            {
                new NHOMNGUOIDUNG{id = 1, MaNhomNguoiDung = "NND001", TenNhomNguoiDung = "Admin"},
                new NHOMNGUOIDUNG{id = 2, MaNhomNguoiDung = "NND002", TenNhomNguoiDung = "Tester"}

            };

            NhomNguoiDungDbSetMock.As<IQueryable<NHOMNGUOIDUNG>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            NhomNguoiDungDbSetMock.As<IQueryable<NHOMNGUOIDUNG>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            NhomNguoiDungDbSetMock.As<IQueryable<NHOMNGUOIDUNG>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            NhomNguoiDungDbSetMock.As<IQueryable<NHOMNGUOIDUNG>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.NHOMNGUOIDUNGs).Returns(NhomNguoiDungDbSetMock.Object);
        }

        [TestMethod]
        public void GetAllNhomNguoiDung_ShouldReturnListOfNguoiDung()
        {
            // Arrange

            var nhomNguoiDung = new NHOMNGUOIDUNG { id = 1, MaNhomNguoiDung = "NND001", TenNhomNguoiDung = "Admin" };
            dbContextMock.Setup(db => db.NHOMNGUOIDUNGs.Find(nhomNguoiDung.id)).Returns(nhomNguoiDung);
            // Act
            List<NHOMNGUOIDUNG> result = dalNhomNguoiDung.GetAllNhomNguoiDung();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void GetNhomNguoiDungById_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingNhomNguoiDungId = 1;
            var nhomNguoiDung = new NHOMNGUOIDUNG { id = 1, MaNhomNguoiDung = "NND001", TenNhomNguoiDung = "Admin" };
            dbContextMock.Setup(db => db.NHOMNGUOIDUNGs.Find(nhomNguoiDung.id)).Returns(nhomNguoiDung);
            // Act
            NHOMNGUOIDUNG result = dalNhomNguoiDung.GetNhomNguoiDungById(existingNhomNguoiDungId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingNhomNguoiDungId, result.id);
        }

        [TestMethod]
        public void GetNhomNguoiDungById_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingTacGiaId = 999;

            // Act
            NHOMNGUOIDUNG result = dalNhomNguoiDung.GetNhomNguoiDungById(nonExistingTacGiaId);

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void GetNhomNguoiDungByMa_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingMaNhomNguoiDung = "NND001";
            var nhomNguoiDung = new NHOMNGUOIDUNG { id = 1, MaNhomNguoiDung = "NND001", TenNhomNguoiDung = "Admin" };
            dbContextMock.Setup(db => db.NHOMNGUOIDUNGs.Find(nhomNguoiDung.id)).Returns(nhomNguoiDung);
            NHOMNGUOIDUNG result = dalNhomNguoiDung.GetNhomNguoiDungByMa(existingMaNhomNguoiDung);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingMaNhomNguoiDung, result.MaNhomNguoiDung);
        }

        [TestMethod]
        public void GetMhomNguoiDungByMa_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingMaTacGia = "NonExistingMaTacGia";

            // Act
            NHOMNGUOIDUNG result = dalNhomNguoiDung.GetNhomNguoiDungByMa(nonExistingMaTacGia);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Test_AddNhomNguoiDung()
        {
            var nhomNguoiDung = new NHOMNGUOIDUNG { id = 1, MaNhomNguoiDung = "NND001", TenNhomNguoiDung = "Admin" };
            int result = dalNhomNguoiDung.AddNhomNguoiDung(nhomNguoiDung);

            Assert.IsTrue(result > 0);

            dbContextMock.Verify(m => m.NHOMNGUOIDUNGs.Add(nhomNguoiDung), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }


        [TestMethod]
        public void UpdTenNhomNguoiDung_ShouldUpdateTongNoForExistingData()
        {
            // Arrange
            var idNhomNguoiDung = 1; // Thay thế bằng một ID độc giả tồn tại trong cơ sở dữ liệu
            var tenNhom = "Test"; // Gả sử một giá trị mới cho tổng nợ

            // Thiết lập dữ liệu giả mạo cho DbSet
            var nhomNguoiDung = new NHOMNGUOIDUNG { id = 1, MaNhomNguoiDung = "NND001", TenNhomNguoiDung = "Admin" };
            dbContextMock.Setup(db => db.NHOMNGUOIDUNGs.Find(nhomNguoiDung.id)).Returns(nhomNguoiDung);

            // Act
            var result = dalNhomNguoiDung.UpdNhomNguoiDung(idNhomNguoiDung, tenNhom);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm UpdTongNoDocGia trả về true khi cập nhật thành công
            Assert.AreEqual(tenNhom, nhomNguoiDung.TenNhomNguoiDung); // Đảm bảo rằng tổng nợ của độc giả đã được cập nhật
        }

        [TestMethod]
        public void UpdTenNhomNguoiDung_ShouldNotUpdateTongNoForNonExistingData()
        {
            // Arrange
            var nonExistingIdNguoiDung = 999; // Thay thế bằng một ID độc giả không tồn tại trong cơ sở dữ liệu
            var tenNhom = "Test"; // Giả sử một giá trị mới cho tổng nợ

            // Act
            var result = dalNhomNguoiDung.UpdNhomNguoiDung(nonExistingIdNguoiDung, tenNhom);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm UpdTongNoDocGia trả về false khi không tìm thấy dữ liệu
        }


        [TestMethod]
        public void AddChucNangForNhom_ShouldAddChucNangForExistingNhom()
        {
            // Arrange
            var idNhom = 1; // Thay thế bằng một ID nhóm người dùng tồn tại trong cơ sở dữ liệu
            var dsChucNang = new List<CHUCNANG>
        {
            new CHUCNANG { id = 1, MaChucNang = "ChucNang 1"},
            // Thêm các đối tượng CHUCNANG khác nếu cần thiết
        };

            // Thiết lập dữ liệu giả mạo cho Nhóm người dùng
            var existingNhom = new NHOMNGUOIDUNG { id = idNhom, CHUCNANGs = dsChucNang };
            dbContextMock.Setup(db => db.NHOMNGUOIDUNGs.Find(existingNhom.id)).Returns(existingNhom);


            // Act
            var result = dalNhomNguoiDung.AddChucNangForNhom(idNhom, dsChucNang);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm AddChucNangForNhom trả về true khi thêm thành công
            Assert.AreEqual(dsChucNang.Count, existingNhom.CHUCNANGs.Count); // Đảm bảo rằng số lượng ChucNang trong Nhóm người dùng được cập nhật đúng
                                       // Kiểm tra nếu cần thiết cho các đối tượng CHUCNANG trong existingNhom.CHUCNANGs
        }

        [TestMethod]
        public void AddChucNangForNhom_ShouldNotAddChucNangForNonExistingNhom()
        {
            // Arrange
            var nonExistingIdNhom = 999; // Thay thế bằng một ID nhóm người dùng không tồn tại trong cơ sở dữ liệu
            var dsChucNang = new List<CHUCNANG>
        {
            new CHUCNANG { /* Thiết lập các thuộc tính cần thiết */ },
            // Thêm các đối tượng CHUCNANG khác nếu cần thiết
        };

            // Act
            var result = dalNhomNguoiDung.AddChucNangForNhom(nonExistingIdNhom, dsChucNang);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm AddChucNangForNhom trả về false khi không tìm thấy Nhóm người dùng
        
        }


        [TestMethod]
        public void DelChucNangForNhom_ShouldRemoveChucNangForExistingNhom()
        {
            // Arrange
            var idNhom = 1; // Thay thế bằng một ID nhóm người dùng tồn tại trong cơ sở dữ liệu
            var dsChucNang = new List<CHUCNANG>
        {
           new CHUCNANG { id = 1, MaChucNang = "ChucNang 1"},
            // Thêm các đối tượng CHUCNANG khác nếu cần thiết
        };

            // Thiết lập dữ liệu giả mạo cho Nhóm người dùng
            var existingNhom = new NHOMNGUOIDUNG { id = idNhom, CHUCNANGs = new List<CHUCNANG>(dsChucNang) /* Các thuộc tính khác có thể cần thiết lập tương ứng */ };
            dbContextMock.Setup(x => x.NHOMNGUOIDUNGs.Find(idNhom)).Returns(existingNhom);

          
            // Act
            var result = dalNhomNguoiDung.DelChucNangForNhom(idNhom, dsChucNang);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelChucNangForNhom trả về true khi xóa thành công
           
        }

        [TestMethod]
        public void DelChucNangForNhom_ShouldNotRemoveChucNangForNonExistingNhom()
        {
            // Arrange
            var nonExistingIdNhom = 999; // Thay thế bằng một ID nhóm người dùng không tồn tại trong cơ sở dữ liệu
            var dsChucNang = new List<CHUCNANG>
        {
            new CHUCNANG { /* Thiết lập các thuộc tính cần thiết */ },
            // Thêm các đối tượng CHUCNANG khác nếu cần thiết
        };

            // Act
            var result = dalNhomNguoiDung.DelChucNangForNhom(nonExistingIdNhom, dsChucNang);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelChucNangForNhom trả về false khi không tìm thấy Nhóm người dùng
        }


        [TestMethod]
        public void DelNhomNguoiDung_ShouldDeleteExistingNguoiDung()
        {
            // Arrange
            var existingNguoiDungId = 1; // Thay thế bằng ID của một TACGIA tồn tại trong cơ sở dữ liệu

            // Thiết lập dữ liệu giả mạo cho DbSet
            var nhomNguoiDung = new NHOMNGUOIDUNG { id = 1, MaNhomNguoiDung = "NND001", TenNhomNguoiDung = "Admin" };
            dbContextMock.Setup(db => db.NHOMNGUOIDUNGs.Find(nhomNguoiDung.id)).Returns(nhomNguoiDung);

            // Act
            bool result = dalNhomNguoiDung.DelNhomNguoiDung(existingNguoiDungId);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            // Kiểm tra xem TACGIA đã được xóa chưa
            NhomNguoiDungDbSetMock.Verify(m => m.Find(existingNguoiDungId), Times.Once);
            NhomNguoiDungDbSetMock.Verify(m => m.Remove(nhomNguoiDung), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelNhomNguoiDung_ShouldReturnFalseForNonExistingNguoiDung()
        {
            // Arrange
            var nonExistingTacGiaId = 999; // Thay thế bằng một ID không tồn tại trong cơ sở dữ liệu

            // Act
            bool result = dalNhomNguoiDung.DelNhomNguoiDung(nonExistingTacGiaId);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }

        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALNhomNguoiDung.Instance;
            var instance2 = DALNhomNguoiDung.Instance;

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
            var dalInstance = new DALNhomNguoiDung(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALNhomNguoiDung();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }


        [TestMethod]
        public void DelBaoCaoA_ShouldReturnFalseOnException()
        {
            // Arrange
            var idBaoCao = 44;
            
            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<NHOMNGUOIDUNG>();
            var listChucNang = new List<CHUCNANG>
            {
                new CHUCNANG{id =1 },
                 new CHUCNANG { id =2 },
            };

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALNhomNguoiDung(dbContextMock.Object);

            // Act
            var result = sut.DelChucNangForNhom(idBaoCao, listChucNang);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DelNhomNguoiDung_ShouldReturnFalseOnException()
        {
            // Arrange
            var idBaoCao = 44;

            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<NHOMNGUOIDUNG>();
       

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALNhomNguoiDung(dbContextMock.Object);

            // Act
            var result = sut.DelNhomNguoiDung(idBaoCao);

            // Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void DelAddChucNang_ShouldReturnFalseOnException()
        {
            // Arrange
            var idBaoCao = 44;

            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<NHOMNGUOIDUNG>();
            var listChucNang = new List<CHUCNANG>
            {
                new CHUCNANG{id =1 },
                 new CHUCNANG { id =2 },
            };

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALNhomNguoiDung(dbContextMock.Object);

            // Act
            var result = sut.AddChucNangForNhom(idBaoCao, listChucNang);

            // Assert
            Assert.IsFalse(result);
        }


        [TestMethod]
        public void DelUpdChucNAng_ShouldReturnFalseOnException()
        {
            // Arrange
            var idBaoCao = 44;

            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<NHOMNGUOIDUNG>();
            var listChucNang = new List<CHUCNANG>
            {
                new CHUCNANG{id =1 },
                 new CHUCNANG { id =2 },
            };

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALNhomNguoiDung(dbContextMock.Object);

            // Act
            var result = sut.UpdNhomNguoiDung(idBaoCao, "TenNhom");

            // Assert
            Assert.IsFalse(result);
        }
    }
}
