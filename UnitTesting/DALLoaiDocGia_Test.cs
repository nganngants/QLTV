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
    public class DALLoaiDocGia_Test
    {
        private DALLoaiDocGia dalLoaiDocGia;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<LOAIDOCGIA>> LoaiDocGiaDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            LoaiDocGiaDbSetMock = new Mock<DbSet<LOAIDOCGIA>>();
            dalLoaiDocGia = new DALLoaiDocGia(dbContextMock.Object);

            var list = new List<LOAIDOCGIA>
            {
                new LOAIDOCGIA{ id = 1, MaLoaiDocGia = "LDG001", TenLoaiDocGia = "Doc Gia 1"},
                new LOAIDOCGIA{ id = 2, MaLoaiDocGia = "LDG002", TenLoaiDocGia = "Doc Gia 2"},

            };

            LoaiDocGiaDbSetMock.As<IQueryable<LOAIDOCGIA>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            LoaiDocGiaDbSetMock.As<IQueryable<LOAIDOCGIA>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            LoaiDocGiaDbSetMock.As<IQueryable<LOAIDOCGIA>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            LoaiDocGiaDbSetMock.As<IQueryable<LOAIDOCGIA>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.LOAIDOCGIAs).Returns(LoaiDocGiaDbSetMock.Object);
        }

        [TestMethod]
        public void GetAllLoaiDocGia_ShouldReturnListOfLoaiDocGia()
        {
            // Arrange

            var loaiDocGia = new LOAIDOCGIA { id = 1, MaLoaiDocGia = "LDG001", TenLoaiDocGia = "Doc Gia 1" };
            dbContextMock.Setup(db => db.LOAIDOCGIAs.Find(loaiDocGia.id)).Returns(loaiDocGia);
            // Act
            List<LOAIDOCGIA> result = dalLoaiDocGia.GetAllLoaiDocGia();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void Test_AddLoaiDocGia()
        {
            var loaiDocGia = new LOAIDOCGIA { id = 1, MaLoaiDocGia = "LDG001", TenLoaiDocGia = "Doc Gia 1" };

            bool result = dalLoaiDocGia.AddLoaiDocGia(loaiDocGia);

            Assert.IsTrue(result);
            LoaiDocGiaDbSetMock.Verify(m => m.Add(loaiDocGia), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetLoaiDocGiaById_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingDocGiaId = 1;
            var loaiDocGia = new LOAIDOCGIA { id = 1, MaLoaiDocGia = "LDG001", TenLoaiDocGia = "Doc Gia 1" };
            dbContextMock.Setup(db => db.LOAIDOCGIAs.Find(loaiDocGia.id)).Returns(loaiDocGia);
            // Act
            LOAIDOCGIA result = dalLoaiDocGia.GetLoaiDocGiaById(existingDocGiaId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingDocGiaId, result.id);
        }

        [TestMethod]
        public void GetLoaiDocGiaById_ShouldReturnNullForNonExistingDocGia()
        {
            // Arrange

            var nonExistingTacGiaId = 999;

            // Act
            LOAIDOCGIA result = dalLoaiDocGia.GetLoaiDocGiaById(nonExistingTacGiaId);

            // Assert
            Assert.IsNull(result);
        }


        [TestMethod]
        public void GetLoaiDocGiaByMa_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingMaLoaiDocGia = "LDG001";
            var loaiDocGia = new LOAIDOCGIA { id = 1, MaLoaiDocGia = "LDG001", TenLoaiDocGia = "Doc Gia 1" };
            dbContextMock.Setup(db => db.LOAIDOCGIAs.Find(loaiDocGia.id)).Returns(loaiDocGia);
            // Act
            LOAIDOCGIA result = dalLoaiDocGia.GetLoaiDocGiaByMa(existingMaLoaiDocGia);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingMaLoaiDocGia, result.MaLoaiDocGia);
        }

        [TestMethod]
        public void GetLoaiDocGiaByMa_ShouldReturnNullForNonExistingLoaiDocGia()
        {
            // Arrange

            var nonExistingMaTacGia = "NonExistingMaTacGia";

            // Act
            LOAIDOCGIA result = dalLoaiDocGia.GetLoaiDocGiaByMa(nonExistingMaTacGia);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void FindLoaiDocGia_ShouldReturnMatchingLoaiDocGia()
        {
            // Arrange
            var tenLoaiDocGia = "Doc Gia 1";
          
            var loaiDocGia = new LOAIDOCGIA { id = 1, MaLoaiDocGia = "LDG001", TenLoaiDocGia = "Doc Gia 1" };
            dbContextMock.Setup(db => db.LOAIDOCGIAs.Find(loaiDocGia.id)).Returns(loaiDocGia);

            // Act
            var result = dalLoaiDocGia.FindLoaiDocGia(tenLoaiDocGia);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null
            Assert.IsTrue(result.Count > 0); // Đảm bảo rằng chỉ có một phần tử trong danh sách
            
        }

        [TestMethod]
        public void FindLoaiDocGia_ShouldReturnEmptyListForNonMatchingData()
        {
            // Arrange
            var tenLoaiDocGia = "Doc Gia 3";

            var loaiDocGia = new LOAIDOCGIA { id = 1, MaLoaiDocGia = "LDG001", TenLoaiDocGia = "Doc Gia 1" };
            dbContextMock.Setup(db => db.LOAIDOCGIAs.Find(loaiDocGia.id)).Returns(loaiDocGia);

            // Act
            var result = dalLoaiDocGia.FindLoaiDocGia(tenLoaiDocGia);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null
            Assert.AreEqual(0, result.Count); // Đảm bảo rằng danh sách trả về là rỗng
        }

        [TestMethod]
        public void UpdLoaiDocGia_ShouldUpdateTongNoForExistingData()
        {
            // Arrange
            var tenLoaiDocGia = "Doc Gia 2"; 
           

            // Thiết lập dữ liệu giả mạo cho DbSet
            var loaiDocGia = new LOAIDOCGIA { id = 1, MaLoaiDocGia = "LDG001", TenLoaiDocGia = "Doc Gia 1" };
            dbContextMock.Setup(db => db.LOAIDOCGIAs.Find(loaiDocGia.id)).Returns(loaiDocGia);


            // Act
            var result = dalLoaiDocGia.UpdLoaiDocGia(loaiDocGia.id, tenLoaiDocGia);

            // Assert
            Assert.IsTrue(result); 
            Assert.AreEqual(tenLoaiDocGia, loaiDocGia.TenLoaiDocGia);

            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void UpdLoaiDocGia_ShouldNotUpdateTongNoForNonExistingData()
        {
            // Arrange
            var nonExistingIdLoaiDocGia = 999;
            var tenLoaiDocGia = "Doc Gia 2";

            // Act
            var result = dalLoaiDocGia.UpdLoaiDocGia(nonExistingIdLoaiDocGia, tenLoaiDocGia);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm UpdTongNoDocGia trả về false khi không tìm thấy dữ liệu
        }

        [TestMethod]
        public void DelLoaiDocGia_ShouldDeleteExistingDocGia()
        {
            // Arrange
            var existingLoaiDocGiaId = 1; // Thay thế bằng ID của một TACGIA tồn tại trong cơ sở dữ liệu

            // Thiết lập dữ liệu giả mạo cho DbSet
            var loaiDocGia = new LOAIDOCGIA { id = 1, MaLoaiDocGia = "LDG001", TenLoaiDocGia = "Doc Gia 1" };
            dbContextMock.Setup(db => db.LOAIDOCGIAs.Find(loaiDocGia.id)).Returns(loaiDocGia);

            // Act
            bool result = dalLoaiDocGia.DelLoaiDocGia(existingLoaiDocGiaId);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            // Kiểm tra xem TACGIA đã được xóa chưa
            LoaiDocGiaDbSetMock.Verify(m => m.Find(existingLoaiDocGiaId), Times.Once);
            LoaiDocGiaDbSetMock.Verify(m => m.Remove(loaiDocGia), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelLoaiDocGia_ShouldReturnFalseForNonExistingDocGia()
        {
            // Arrange
            var nonExistingTacGiaId = 999; // Thay thế bằng một ID không tồn tại trong cơ sở dữ liệu

            // Act
            bool result = dalLoaiDocGia.DelLoaiDocGia(nonExistingTacGiaId);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }



        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALLoaiDocGia.Instance;
            var instance2 = DALLoaiDocGia.Instance;

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
            var dalInstance = new DALLoaiDocGia(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALLoaiDocGia();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }
    }
}
