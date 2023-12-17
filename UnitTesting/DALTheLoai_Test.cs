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
    public class DALTheLoai_Test
    {
        private DALTheLoai dalTheLoai;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<THELOAI>> theLoaiDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            theLoaiDbSetMock = new Mock<DbSet<THELOAI>>();
            dalTheLoai = new DALTheLoai(dbContextMock.Object);

            var list = new List<THELOAI>
            {
                    new THELOAI{id = 1, MaTheLoai = "TL001", TenTheLoai = "TheLoai1"},
                        new THELOAI{id = 2, MaTheLoai = "TL002", TenTheLoai = "TheLoai2"}

            };

            theLoaiDbSetMock.As<IQueryable<THELOAI>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            theLoaiDbSetMock.As<IQueryable<THELOAI>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            theLoaiDbSetMock.As<IQueryable<THELOAI>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            theLoaiDbSetMock.As<IQueryable<THELOAI>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.THELOAIs).Returns(theLoaiDbSetMock.Object);
        }

        [TestMethod]
        public void GetAllPhieuThu_ShouldReturnListOfNguoiDung()
        {
            // Arrange

            var theLoai = new THELOAI { id = 1, MaTheLoai = "TL001", TenTheLoai = "TheLoai1" };
            dbContextMock.Setup(db => db.THELOAIs.Find(theLoai.id)).Returns(theLoai);
            // Act
            List<THELOAI> result = dalTheLoai.GetAllTheLoai();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void GetPhieuThuById_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingId = 1;
            var theLoai = new THELOAI { id = 1, MaTheLoai = "TL001", TenTheLoai = "TheLoai1" };
            dbContextMock.Setup(db => db.THELOAIs.Find(theLoai.id)).Returns(theLoai);
            // Act
            THELOAI result = dalTheLoai.GetTheLoaiById(existingId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingId, result.id);
        }

        [TestMethod]
        public void GetPhieuThuById_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingTacGiaId = 999;

            // Act
            THELOAI result = dalTheLoai.GetTheLoaiById(nonExistingTacGiaId);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetNguoiDungByUsername_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingMaTheLoai = "TL001";
            var theLoai = new THELOAI { id = 1, MaTheLoai = "TL001", TenTheLoai = "TheLoai1" };
            dbContextMock.Setup(db => db.THELOAIs.Find(theLoai.id)).Returns(theLoai);
            THELOAI result = dalTheLoai.GetTheLoaiByMa(existingMaTheLoai);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingMaTheLoai, result.MaTheLoai);
        }

        [TestMethod]
        public void GetNguoiDungByUsername_ShouldReturnNullForNonExistingNguoiDung()
        {
            // Arrange

            var nonExistingMaTacGia = "NonExistingMaTacGia";

            // Act
            THELOAI result = dalTheLoai.GetTheLoaiByMa(nonExistingMaTacGia);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void FindTheoNgayNhap_ShouldReturnMatchingLoaiPhieuMuonTra()
        {
            // Arrange
            var tenTheLoai = "TheLoai1";

            var theLoai = new THELOAI { id = 1, MaTheLoai = "TL001", TenTheLoai = "TheLoai1" };
            dbContextMock.Setup(db => db.THELOAIs.Find(theLoai.id)).Returns(theLoai);

            // Act
            var result = dalTheLoai.FindTheLoai(tenTheLoai);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null
            Assert.IsTrue(result.Count > 0); // Đảm bảo rằng chỉ có một phần tử trong danh sách

        }

        [TestMethod]
        public void FindTheoNgayMuon_ShouldReturnEmptyListForNonMatchingData()
        {
            // Arrange
            var tenTheLoai = "TheLoai3";

            var theLoai = new THELOAI { id = 1, MaTheLoai = "TL001", TenTheLoai = "TheLoai1" };
            dbContextMock.Setup(db => db.THELOAIs.Find(theLoai.id)).Returns(theLoai);
            // Act
            var result = dalTheLoai.FindTheLoai(tenTheLoai);


            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null

        }

        [TestMethod]
        public void Test_AddTheLoai()
        {
            var theLoai = new THELOAI { id = 1, MaTheLoai = "TL001", TenTheLoai = "TheLoai1" };


            bool result = dalTheLoai.AddTheLoai(theLoai);

            Assert.IsTrue(result);
            theLoaiDbSetMock.Verify(m => m.Add(theLoai), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }


        [TestMethod]
        public void UpdPhieuNhap_ShouldUpdateExistingTacGia()
        {
            // Arrange
            var id = 1;
            var tenTheLoai = "TheLoai3";
        
            var theLoai = new THELOAI { id = 1, MaTheLoai = "TL001", TenTheLoai = "TheLoai1" };
            dbContextMock.Setup(db => db.THELOAIs.Find(theLoai.id)).Returns(theLoai);


            // Lưu giá trị ban đầu


            // Act
            bool result = dalTheLoai.UpdTheLoai(id, tenTheLoai );

            // Assert
            Assert.IsTrue(result);

            //// Kiểm tra xem TACGIA đã được cập nhật chưa
            theLoaiDbSetMock.Verify(m => m.Find(id), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

            //// Kiểm tra giá trị trước cập nhật và sau cập nhật
            Assert.AreEqual(tenTheLoai, theLoai.TenTheLoai);




        }

        [TestMethod]
        public void UpdTacGia_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var id = 999;
            var tenTheLoai = "TheLoai3";


            // Act
            bool result = dalTheLoai.UpdTheLoai(id, tenTheLoai);
            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DelTacGia_ShouldDeleteExistingTacGia()
        {
            var id = 1;

            var theLoai = new THELOAI { id = 1, MaTheLoai = "TL001", TenTheLoai = "TheLoai1" };
            dbContextMock.Setup(db => db.THELOAIs.Find(theLoai.id)).Returns(theLoai);

            // 
            bool result = dalTheLoai.DelTheLoai(id);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            // Kiểm tra xem TACGIA đã được xóa 
            theLoaiDbSetMock.Verify(m => m.Find(id), Times.Once);
            theLoaiDbSetMock.Verify(m => m.Remove(theLoai), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelTacGia_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var nonExistingTacGiaId = 999; // Thay thế bằng một ID không tồn tại trong cơ sở dữ liệu

            // Act
            bool result = dalTheLoai.DelTheLoai(nonExistingTacGiaId);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }

        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALTheLoai.Instance;
            var instance2 = DALTheLoai.Instance;

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
            var dalInstance = new DALTheLoai(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALTheLoai();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }
    }
}
