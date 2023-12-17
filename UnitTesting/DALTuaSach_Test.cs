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
    public class DALTuaSach_Test
    {
        private DALTuaSach dalTuaSach;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<TUASACH>> tuaSachDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            tuaSachDbSetMock = new Mock<DbSet<TUASACH>>();
            dalTuaSach = new DALTuaSach(dbContextMock.Object);

            var list = new List<TUASACH>
            {
                    new TUASACH {id = 1, MaTuaSach = "TS001", TenTuaSach = "Tua Sach 001"},

                    new TUASACH {id = 2, MaTuaSach = "TS002", TenTuaSach = "Tua Sach 002"},

            };

            tuaSachDbSetMock.As<IQueryable<TUASACH>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            tuaSachDbSetMock.As<IQueryable<TUASACH>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            tuaSachDbSetMock.As<IQueryable<TUASACH>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            tuaSachDbSetMock.As<IQueryable<TUASACH>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.TUASACHes).Returns(tuaSachDbSetMock.Object);
        }

        [TestMethod]
        public void GetAllTuaSach_ShouldReturnListOfNguoiDung()
        {
            // Arrange

            var tuaSach = new TUASACH { id = 1, MaTuaSach = "TS001", TenTuaSach = "Tua Sach 001" };
            dbContextMock.Setup(db => db.TUASACHes.Find(tuaSach.id)).Returns(tuaSach);
            // Act
            List<TUASACH> result = dalTuaSach.GetAllTuaSach();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }


        [TestMethod]
        public void GetTuaSachById_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingId = 1;
            var tuaSach = new TUASACH { id = 1, MaTuaSach = "TS001", TenTuaSach = "Tua Sach 001" };
            dbContextMock.Setup(db => db.TUASACHes.Find(tuaSach.id)).Returns(tuaSach);
            // Act
            TUASACH result = dalTuaSach.GetTuaSachById(existingId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingId, result.id);
        }

        [TestMethod]
        public void GetTuaSachById_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingTacGiaId = 999;

            // Act
            TUASACH result = dalTuaSach.GetTuaSachById(nonExistingTacGiaId);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetNguoiDungByUsername_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingMaTuaSach= "TS001";
            var tuaSach = new TUASACH { id = 1, MaTuaSach = "TS001", TenTuaSach = "Tua Sach 001" };
            dbContextMock.Setup(db => db.TUASACHes.Find(tuaSach.id)).Returns(tuaSach);

            TUASACH result = dalTuaSach.GetTuaSachByMa(existingMaTuaSach);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingMaTuaSach, result.MaTuaSach);
        }

        [TestMethod]
        public void GetNguoiDungByUsername_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingMaTacGia = "NonExistingMaTacGia";

            // Act
            TUASACH result = dalTuaSach.GetTuaSachByMa(nonExistingMaTacGia);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void DelTacGia_ShouldDeleteExistingTacGia()
        {
            var id = 1;

            var tuaSach = new TUASACH { id = 1, MaTuaSach = "TS001", TenTuaSach = "Tua Sach 001" };
            dbContextMock.Setup(db => db.TUASACHes.Find(tuaSach.id)).Returns(tuaSach);

            // 
            bool result = dalTuaSach.DelTuaSach(id);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            // Kiểm tra xem TACGIA đã được xóa 
            tuaSachDbSetMock.Verify(m => m.Find(id), Times.Once);
            tuaSachDbSetMock.Verify(m => m.Remove(tuaSach), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelTacGia_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var nonExistingTacGiaId = 999; // Thay thế bằng một ID không tồn tại trong cơ sở dữ liệu

            // Act
            bool result = dalTuaSach.DelTuaSach(nonExistingTacGiaId);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }

        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALTuaSach.Instance;
            var instance2 = DALTuaSach.Instance;

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
            var dalInstance = new DALTuaSach(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALTuaSach();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }
    }
}
