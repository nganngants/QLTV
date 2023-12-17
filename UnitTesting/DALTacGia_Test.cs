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
    public class DALTacGia_Test
    {
        private DALTacGia dalTacGia;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<TACGIA>> tacGiaDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            tacGiaDbSetMock = new Mock<DbSet<TACGIA>>();
            dalTacGia = new DALTacGia(dbContextMock.Object);

            var listTacGia = new List<TACGIA>
            {
                new TACGIA{id  = 1, MATACGIA = "TacGia001", TenTacGia = "Nguyen Van A"},
                new TACGIA{id  = 2, MATACGIA = "TacGia002", TenTacGia = "Nguyen Van B"},
            };

            tacGiaDbSetMock.As<IQueryable<TACGIA>>().Setup(m => m.Provider).Returns(listTacGia.AsQueryable().Provider);
            tacGiaDbSetMock.As<IQueryable<TACGIA>>().Setup(m => m.Expression).Returns(listTacGia.AsQueryable().Expression);
            tacGiaDbSetMock.As<IQueryable<TACGIA>>().Setup(m => m.ElementType).Returns(listTacGia.AsQueryable().ElementType);
            tacGiaDbSetMock.As<IQueryable<TACGIA>>().Setup(m => m.GetEnumerator()).Returns(listTacGia.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.TACGIAs).Returns(tacGiaDbSetMock.Object);
        }

        [TestMethod]
        public void GetAllTacGia_ShouldReturnListOfTacGia()
        {
            // Arrange

            var tacgia = new TACGIA { id  = 1, MATACGIA = "TacGia001", TenTacGia = "Nguyen Van A" };
            dbContextMock.Setup(db => db.TACGIAs.Find(tacgia.id)).Returns(tacgia);
            // Act
            List<TACGIA> result = dalTacGia.GetAllTacGia();


            // Assert
            Assert.IsNotNull(result); 

            Assert.IsTrue(result.Count > 0);

        }


        [TestMethod]
        public void GetTacGiaById_ShouldReturnTacGiaIfExists()
        {
            // Arrange
           
            var existingTacGiaId = 1;
            var tacgia = new TACGIA { id  = 1, MATACGIA = "TacGia001", TenTacGia = "Nguyen Van A" };
            dbContextMock.Setup(db => db.TACGIAs.Find(tacgia.id)).Returns(tacgia);
            // Act
            TACGIA result = dalTacGia.GetTacGiaById(existingTacGiaId);

            // Assert
            Assert.IsNotNull(result); 
            Assert.AreEqual(existingTacGiaId, result.id); 
        }

        [TestMethod]
        public void GetTacGiaById_ShouldReturnNullForNonExistingTacGia()
        {
            // Arrange
           
            var nonExistingTacGiaId = 999; 

            // Act
            TACGIA result = dalTacGia.GetTacGiaById(nonExistingTacGiaId);

            // Assert
            Assert.IsNull(result); 
        }

        [TestMethod]
        public void GetTacGiaByMa_ShouldReturnTacGiaIfExists()
        {
            // Arrange
            
            var existingMaTacGia = "TacGia001";
            var tacgia = new TACGIA { id  = 1, MATACGIA = "TacGia001", TenTacGia = "Nguyen Van A" };
            dbContextMock.Setup(db => db.TACGIAs.Find(tacgia.id)).Returns(tacgia);
            // Act
            TACGIA result = dalTacGia.GetTacGiaByMa(existingMaTacGia);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingMaTacGia, result.MATACGIA);
        }

        [TestMethod]
        public void GetTacGiaByMa_ShouldReturnNullForNonExistingTacGia()
        {
            // Arrange
            
            var nonExistingMaTacGia = "NonExistingMaTacGia"; 

            // Act
            TACGIA result = dalTacGia.GetTacGiaByMa(nonExistingMaTacGia);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void FindTacGia_ShouldReturnListOfTacGia()
        {
            // Arrange
          
            var existingTenTacGia = "Nguyen Van A";
            var tacgia = new TACGIA { id  = 1, MATACGIA = "TacGia001", TenTacGia = "Nguyen Van A" };
            dbContextMock.Setup(db => db.TACGIAs.Find(tacgia.id)).Returns(tacgia);

            // Act
            List<TACGIA> result = dalTacGia.FindTacGia(existingTenTacGia);

            // Assert
            Assert.IsNotNull(result); 

           
            Assert.IsTrue(result.Count > 0);

            
            foreach (var tacGia in result)
            {
                Assert.IsInstanceOfType(tacGia, typeof(TACGIA));
                Assert.AreEqual(existingTenTacGia, tacGia.TenTacGia); 
            }
        }

        [TestMethod]
        public void UpdTacGia_ShouldUpdateExistingTacGia()
        {
            // Arrange
            var existingTacGiaId = 1; 
            var newTenTacGia = "Lam Van C"; 

            // Thiết lập dữ liệu giả mạo cho DbSet
            var existingTacGia = new TACGIA { id = existingTacGiaId, TenTacGia = "Nguyen Van A" };
            dbContextMock.Setup(db => db.TACGIAs.Find(existingTacGiaId)).Returns(existingTacGia);


            // Lưu giá trị ban đầu
            var initialTenTacGia = existingTacGia.TenTacGia;

            // Act
            bool result = dalTacGia.UpdTacGia(existingTacGiaId, newTenTacGia);

            // Assert
            Assert.IsTrue(result); 

            //// Kiểm tra xem TACGIA đã được cập nhật chưa
            tacGiaDbSetMock.Verify(m => m.Find(existingTacGiaId), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

            //// Kiểm tra giá trị trước cập nhật và sau cập nhật
            Assert.AreEqual(newTenTacGia, existingTacGia.TenTacGia); 
         
        }

        [TestMethod]
        public void UpdTacGia_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var nonExistingTacGiaId = 999;
            var newTenTacGia = "Lam Van C"; 

            // Act
            bool result = dalTacGia.UpdTacGia(nonExistingTacGiaId, newTenTacGia);

            // Assert
            Assert.IsFalse(result); 
        }


        [TestMethod]
        public void DelTacGia_ShouldDeleteExistingTacGia()
        {
            // Arrange
            var existingTacGiaId = 1; // Thay thế bằng ID của một TACGIA tồn tại trong cơ sở dữ liệu

            // Thiết lập dữ liệu giả mạo cho DbSet
            var existingTacGia = new TACGIA { id = existingTacGiaId, TenTacGia = "Nguyen Van A" };
            dbContextMock.Setup(db => db.TACGIAs.Find(existingTacGiaId)).Returns(existingTacGia);

            // Act
            bool result = dalTacGia.DelTacGia(existingTacGiaId);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            // Kiểm tra xem TACGIA đã được xóa chưa
            tacGiaDbSetMock.Verify(m => m.Find(existingTacGiaId), Times.Once);
            tacGiaDbSetMock.Verify(m => m.Remove(existingTacGia), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelTacGia_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var nonExistingTacGiaId = 999; // Thay thế bằng một ID không tồn tại trong cơ sở dữ liệu

            // Act
            bool result = dalTacGia.DelTacGia(nonExistingTacGiaId);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }

        [TestMethod]
        public void Test_AddTacGia()
        {
            var tacgia = new TACGIA { id  = 1, MATACGIA = "TacGia001", TenTacGia = "Nguyen Van A" };


            int id = dalTacGia.AddTacGia(tacgia);

            Assert.IsTrue(id > 0);
            tacGiaDbSetMock.Verify(m => m.Add(tacgia), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }


        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALTacGia.Instance;
            var instance2 = DALTacGia.Instance;

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
            var dalInstance = new DALTacGia(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALTacGia();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }
    }
}
    