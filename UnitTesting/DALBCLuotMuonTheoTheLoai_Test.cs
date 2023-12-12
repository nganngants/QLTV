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
    public class DALBCLuotMuonTheoTheLoai_Test
    {
        private DALBCLuotMuonTheoTheLoai dalBCLuotMuonTheoTheLoai;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<BCLUOTMUONTHEOTHELOAI>> bcLuotMuonTheoTheLoaiDbSetMock;
        private Mock<DbSet<CT_BCLUOTMUONTHEOTHELOAI>> bcctLuotMuonTheoTheLoaiDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            bcLuotMuonTheoTheLoaiDbSetMock = new Mock<DbSet<BCLUOTMUONTHEOTHELOAI>>();
            bcctLuotMuonTheoTheLoaiDbSetMock = new Mock<DbSet<CT_BCLUOTMUONTHEOTHELOAI>>();
            dalBCLuotMuonTheoTheLoai = new DALBCLuotMuonTheoTheLoai(dbContextMock.Object);

            var listTacGia = new List<BCLUOTMUONTHEOTHELOAI>
            {
                new BCLUOTMUONTHEOTHELOAI{id = 1, Thang = 2, Nam = 2023, TongSoLuotMuon = 10, MaBaoCao = "BC001"},
                new BCLUOTMUONTHEOTHELOAI{id = 2, Thang = 2, Nam = 2023, TongSoLuotMuon = 10, MaBaoCao = "BC002"},
            };

            bcLuotMuonTheoTheLoaiDbSetMock.As<IQueryable<BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Provider).Returns(listTacGia.AsQueryable().Provider);
            bcLuotMuonTheoTheLoaiDbSetMock.As<IQueryable<BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Expression).Returns(listTacGia.AsQueryable().Expression);
            bcLuotMuonTheoTheLoaiDbSetMock.As<IQueryable<BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.ElementType).Returns(listTacGia.AsQueryable().ElementType);
            bcLuotMuonTheoTheLoaiDbSetMock.As<IQueryable<BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.GetEnumerator()).Returns(listTacGia.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.BCLUOTMUONTHEOTHELOAIs).Returns(bcLuotMuonTheoTheLoaiDbSetMock.Object);
        }


        [TestMethod]
        public void GetAllBCLuotMuonTheoTheLoai_ShouldReturnListOfTacGia()
        {
            // Arrange

            var baocao = new BCLUOTMUONTHEOTHELOAI { id = 1, Thang = 2, Nam = 2023, TongSoLuotMuon = 10, MaBaoCao = "BC001" };
            dbContextMock.Setup(db => db.BCLUOTMUONTHEOTHELOAIs.Find(baocao.id)).Returns(baocao);
            // Act
            List<BCLUOTMUONTHEOTHELOAI> result = dalBCLuotMuonTheoTheLoai.GetAllBaoCao();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }


        [TestMethod]
        public void GetBCLuotMuonTheoTheLoaiById_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingId = 1;
            var baocao = new BCLUOTMUONTHEOTHELOAI { id = 1, Thang = 2, Nam = 2023, TongSoLuotMuon = 10, MaBaoCao = "BC001" };
            dbContextMock.Setup(db => db.BCLUOTMUONTHEOTHELOAIs.Find(baocao.id)).Returns(baocao);
            // Act
            BCLUOTMUONTHEOTHELOAI result = dalBCLuotMuonTheoTheLoai.GetBaoCaoById(existingId);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingId, result.id);
        }

        [TestMethod]
        public void GetBCLuotMuonTheoTheLoaiById_ShouldReturnNullForNonExistingTacGia()
        {
            // Arrange

            var nonExistingId = 999;

            // Act
            BCLUOTMUONTHEOTHELOAI result = dalBCLuotMuonTheoTheLoai.GetBaoCaoById(nonExistingId);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetBCLuotMuonTheoTheLoaiByMa_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var existingMaBaoCao = "BaoCao001";
            
            var baocao = new BCLUOTMUONTHEOTHELOAI { id = 1, Thang = 2, Nam = 2023, TongSoLuotMuon = 10, MaBaoCao = "BaoCao001" };
            var data = new List<BCLUOTMUONTHEOTHELOAI> { baocao };
            var mockData = data.AsQueryable();
            bcLuotMuonTheoTheLoaiDbSetMock.As<IQueryable<BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Provider).Returns(mockData.Provider);
            bcLuotMuonTheoTheLoaiDbSetMock.As<IQueryable<BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Expression).Returns(mockData.Expression);
            bcLuotMuonTheoTheLoaiDbSetMock.As<IQueryable<BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            bcLuotMuonTheoTheLoaiDbSetMock.As<IQueryable<BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());

            // Act
            BCLUOTMUONTHEOTHELOAI result = dalBCLuotMuonTheoTheLoai.GetBaoCaoByMa(existingMaBaoCao);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(existingMaBaoCao, result.MaBaoCao);
        }

        [TestMethod]
        public void GetBCLuotMuonTheoTheLoaiByMa_ShouldReturnNullForNonExistingTacGia()
        {
            // Arrange

            var nonExistingMaBaoCao = "NonExistingMaBaoCao";

            // Act
            BCLUOTMUONTHEOTHELOAI result = dalBCLuotMuonTheoTheLoai.GetBaoCaoByMa(nonExistingMaBaoCao);

            // Assert
            Assert.IsNull(result);
        }

      
        [TestMethod]
        public void Test_AddBCLuotMuonTheoTheLoai()
        {
            var baocao = new BCLUOTMUONTHEOTHELOAI { id = 1, Thang = 2, Nam = 2023, TongSoLuotMuon = 10, MaBaoCao = "BaoCao001" };


            int id = dalBCLuotMuonTheoTheLoai.AddBaoCao(baocao);

            dbContextMock.Verify(m => m.BCLUOTMUONTHEOTHELOAIs.Add(baocao), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

        }

        /*
        [TestMethod]
        public void Compute_ShouldComputeAndSaveChanges()
        {
            // Arrange
            var id = 1; // Thay thế bằng một ID tồn tại trong cơ sở dữ liệu

            
            var ctBaoCao1 = new CT_BCLUOTMUONTHEOTHELOAI { idTheLoai = 1, idBaoCao = id, SoLuotMuon = 10, };
            var ctBaoCao2 = new CT_BCLUOTMUONTHEOTHELOAI { idTheLoai = 2, idBaoCao = id, SoLuotMuon = 20, };

            dbContextMock.Setup(db => db.BCLUOTMUONTHEOTHELOAIs.Find(baoCao.id)).Returns(baoCao);
            dbContextMock.Setup(db => db.CT_BCLUOTMUONTHEOTHELOAI.Find(ctBaoCao1.idTheLoai)).Returns(ctBaoCao1);
            dbContextMock.Setup(db => db.CT_BCLUOTMUONTHEOTHELOAI.Find(ctBaoCao2.idTheLoai)).Returns(ctBaoCao2);

          
            // Act
            var result = dalBCLuotMuonTheoTheLoai.Compute(id);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm Compute trả về true khi tính toán và lưu các thay đổi thành công

            // Kiểm tra xem SaveChanges đã được gọi
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

            // Kiểm tra giá trị của TongSoLuotMuon đã được tính toán đúng
            Assert.AreNotEqual(30, baoCao.TongSoLuotMuon);

            // Kiểm tra giá trị của TiLe cho mỗi CT_BC đã được tính toán đúng
            Assert.AreNotEqual(0.3333m, ctBaoCao1.TiLe);
            Assert.AreNotEqual(0.6667m, ctBaoCao2.TiLe);
        }*/

       
        [TestMethod]
        public void DelBC_ShouldDeleteExistingTacGia()
        {
            // Arrange
            var existingId = 1; // Thay thế bằng ID của một TACGIA tồn tại trong cơ sở dữ liệu

            // Thiết lập dữ liệu giả mạo cho DbSet
         
            var baocao = new BCLUOTMUONTHEOTHELOAI { id = existingId, Thang = 2, Nam = 2023, TongSoLuotMuon = 10, MaBaoCao = "BC001" };
            dbContextMock.Setup(db => db.BCLUOTMUONTHEOTHELOAIs.Find(baocao.id)).Returns(baocao);
            // Act
            bool result = dalBCLuotMuonTheoTheLoai.DelBaoCao(existingId);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công

            // Kiểm tra xem TACGIA đã được xóa chưa
            bcLuotMuonTheoTheLoaiDbSetMock.Verify(m => m.Find(existingId), Times.Once);
            bcLuotMuonTheoTheLoaiDbSetMock.Verify(m => m.Remove(baocao), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void DelBC_ShouldReturnFalseForNonExistingTacGia()
        {
            // Arrange
            var nonExistingTacGiaId = 999; // Thay thế bằng một ID không tồn tại trong cơ sở dữ liệu

            // Act
            bool result = dalBCLuotMuonTheoTheLoai.DelBaoCao(nonExistingTacGiaId);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }

        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALBCLuotMuonTheoTheLoai.Instance;
            var instance2 = DALBCLuotMuonTheoTheLoai.Instance;

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
            var dalInstance = new DALBCLuotMuonTheoTheLoai(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALBCLuotMuonTheoTheLoai();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }

        [TestMethod]
        public void FindTheoNgayNhap_ShouldReturnMatching()
        {
            // Arrange
            var thang = 2;
            var nam = 2023;

            var bc = new BCLUOTMUONTHEOTHELOAI { id = 1, Thang = 2, Nam = 2023, TongSoLuotMuon = 10, MaBaoCao = "BC001" };
            dbContextMock.Setup(db => db.BCLUOTMUONTHEOTHELOAIs.Find(bc.id)).Returns(bc);

            // Act
            var result = dalBCLuotMuonTheoTheLoai.FindBaoCaoByDate(thang, nam);

            // Assert
            Assert.IsNotNull(result); // Đảm bảo rằng danh sách trả về không null
            Assert.IsTrue(result.Count > 0); // Đảm bảo rằng chỉ có một phần tử trong danh sách

        }

        [TestMethod]
        public void DelBaoCao_ShouldReturnFalseOnException()
        {
            // Arrange
            var bcId = 1;
            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<BCLUOTMUONTHEOTHELOAI>();

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();
            dbContextMock.Setup(db => db.BCLUOTMUONTHEOTHELOAIs.Find(bcId)).Returns(bcMock.Object);
            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALBCLuotMuonTheoTheLoai(dbContextMock.Object);

            // Act
            var result = sut.DelBaoCao(bcId);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
