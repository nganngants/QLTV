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
    public class DALCT_BCLuotMuonTheoTheLoai_Test
    {
        private DALCT_BCLuotMuonTheoTheLoai dalCTBCTheoTheLoai;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<CT_BCLUOTMUONTHEOTHELOAI>> CTBCDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb>();
            CTBCDbSetMock = new Mock<DbSet<CT_BCLUOTMUONTHEOTHELOAI>>();
            dalCTBCTheoTheLoai = new DALCT_BCLuotMuonTheoTheLoai(dbContextMock.Object);

            var list = new List<CT_BCLUOTMUONTHEOTHELOAI>
            {
                new CT_BCLUOTMUONTHEOTHELOAI {idBaoCao = 1, idTheLoai = 1, SoLuotMuon = 2},
                   new CT_BCLUOTMUONTHEOTHELOAI {idBaoCao = 2, idTheLoai = 2, SoLuotMuon = 2},

            };

            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Provider).Returns(list.AsQueryable().Provider);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Expression).Returns(list.AsQueryable().Expression);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.ElementType).Returns(list.AsQueryable().ElementType);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.GetEnumerator()).Returns(list.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.CT_BCLUOTMUONTHEOTHELOAI).Returns(CTBCDbSetMock.Object);
        }


        [TestMethod]
        public void GetCTBC_ShouldReturnTacGiaIfExists()
        {
            // Arrange

            var idBaoCao = 1;
            var idTheLoai = 1;
            var baocao = new CT_BCLUOTMUONTHEOTHELOAI { idBaoCao = 1, idTheLoai = 1, SoLuotMuon = 2 };
            var data = new List<CT_BCLUOTMUONTHEOTHELOAI> { baocao };
            var mockData = data.AsQueryable();
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Provider).Returns(mockData.Provider);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Expression).Returns(mockData.Expression);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());

            // Act
            CT_BCLUOTMUONTHEOTHELOAI result = dalCTBCTheoTheLoai.GetCTBC(idBaoCao, idTheLoai);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(idBaoCao, result.idBaoCao);
            Assert.AreEqual(idTheLoai, result.idTheLoai);
        }

        [TestMethod]
        public void GetCTBC_ShouldReturnNullForNonExistingBaoCao()
        {
            // Arrange

            var nonExistingIdBC = 999; 
            var nonExistingIdTheLoai = 888;

            // Act
            CT_BCLUOTMUONTHEOTHELOAI result = dalCTBCTheoTheLoai.GetCTBC(nonExistingIdBC, nonExistingIdTheLoai);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void GetAllCTBC_ShouldReturnListOfBaoCao()
        {
            // Arrange

            var idBaoCao = 1;
            var idTheLoai = 1;
            var baocao = new CT_BCLUOTMUONTHEOTHELOAI { idBaoCao = 1, idTheLoai = 1, SoLuotMuon = 2 };
            var data = new List<CT_BCLUOTMUONTHEOTHELOAI> { baocao };
            var mockData = data.AsQueryable();
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Provider).Returns(mockData.Provider);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Expression).Returns(mockData.Expression);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());

            // Act

            List<CT_BCLUOTMUONTHEOTHELOAI> result = dalCTBCTheoTheLoai.GetAllCTBC();


            // Assert
            Assert.IsNotNull(result);

            Assert.IsTrue(result.Count > 0);

        }

        [TestMethod]
        public void Test_AddCTBC()
        {
            var baocao = new CT_BCLUOTMUONTHEOTHELOAI { idBaoCao = 1, idTheLoai = 1, SoLuotMuon = 2 };

            bool result = dalCTBCTheoTheLoai.AddCTBC(baocao);

            Assert.IsTrue(result);

            dbContextMock.Verify(m => m.CT_BCLUOTMUONTHEOTHELOAI.Add(baocao), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

        }

        [TestMethod]
        public void UpdCTBC_ShouldUpdateExistingBaoCao()
        {
            // Arrange
            var idBaoCao = 1;
            var idTheLoai = 1;
            var soLuotMuon = 2;

            // Thiết lập dữ liệu giả mạo cho DbSet
            var existingCTBC = new CT_BCLUOTMUONTHEOTHELOAI { idBaoCao = idBaoCao, idTheLoai = idTheLoai, SoLuotMuon = soLuotMuon };
            var data = new List<CT_BCLUOTMUONTHEOTHELOAI> { existingCTBC };
            var mockData = data.AsQueryable();
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Provider).Returns(mockData.Provider);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Expression).Returns(mockData.Expression);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());


            // Lưu giá trị ban đầu
            var initialSoLuotMuon = existingCTBC.SoLuotMuon;

            // Act
            bool result = dalCTBCTheoTheLoai.UpdCTBC(idBaoCao, idTheLoai, soLuotMuon);

            // Assert
            Assert.IsTrue(result);

            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);



        }

        [TestMethod]
        public void DelBaoCao_ShouldReturnFalseOnException()
        {
            // Arrange
            var idBaoCao = 44;
            var idTheLoai = 44;
            var soLuotMuon = 2;
            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<CT_BCLUOTMUONTHEOTHELOAI>();

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALCT_BCLuotMuonTheoTheLoai(dbContextMock.Object);

            // Act
            var result = sut.UpdCTBC(idBaoCao, idTheLoai, soLuotMuon);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UpdCTBC_ShouldReturnFalseForNonExistingBaoCao()
        {
            // Arrange
            var idBaoCao = 1;
            var idTheLoai = 2;
            var soLuotMuon = 2;
            // Act
            bool result = dalCTBCTheoTheLoai.UpdCTBC(idBaoCao, idTheLoai, soLuotMuon);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DelCTBC_ShouldDeleteExistingBaoCao()
        {
            // Arrange
            var idBaoCao = 1;
            var idTheLoai = 1;
            var soLuotMuon = 2;

            // Thiết lập dữ liệu giả mạo cho DbSet
            var existingCTBC = new CT_BCLUOTMUONTHEOTHELOAI { idBaoCao = idBaoCao, idTheLoai = idTheLoai, SoLuotMuon = soLuotMuon };
            var data = new List<CT_BCLUOTMUONTHEOTHELOAI> { existingCTBC };
            var mockData = data.AsQueryable();
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Provider).Returns(mockData.Provider);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.Expression).Returns(mockData.Expression);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.ElementType).Returns(mockData.ElementType);
            CTBCDbSetMock.As<IQueryable<CT_BCLUOTMUONTHEOTHELOAI>>().Setup(m => m.GetEnumerator()).Returns(mockData.GetEnumerator());
                

            // Act
            bool result = dalCTBCTheoTheLoai.DelCTBC(idBaoCao, idTheLoai);

            // Assert
            Assert.IsTrue(result); // Đảm bảo rằng hàm DelTacGia trả về true khi xóa thành công
            CTBCDbSetMock.Verify(m => m.Remove(existingCTBC), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

        }

        [TestMethod]
        public void DelCTBC_ShouldReturnFalseForNonExistingBaoCao()
        {
            // Arrange
            var idBaoCao = 1;
            var idTheLoai = 2;
            var soLuotMuon = 2;

            // Act
            bool result = dalCTBCTheoTheLoai.DelCTBC(idBaoCao, idTheLoai);

            // Assert
            Assert.IsFalse(result); // Đảm bảo rằng hàm DelTacGia trả về false khi xóa TACGIA không tồn tại
        }

        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALCT_BCLuotMuonTheoTheLoai.Instance;
            var instance2 = DALCT_BCLuotMuonTheoTheLoai.Instance;

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
            var dalInstance = new DALCT_BCLuotMuonTheoTheLoai(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALCT_BCLuotMuonTheoTheLoai();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }


        [TestMethod]
        public void DelBaoCaoA_ShouldReturnFalseOnException()
        {
            // Arrange
            var idBaoCao = 44;
            var idTheLoai = 44;
            var soLuotMuon = 2;
            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<CT_BCLUOTMUONTHEOTHELOAI>();

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALCT_BCLuotMuonTheoTheLoai(dbContextMock.Object);

            // Act
            var result = sut.DelCTBC(idBaoCao, idTheLoai);
            
            // Assert
            Assert.IsFalse(result);
        }
    }
}
