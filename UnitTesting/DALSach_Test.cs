using DAL;
using DTO;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UnitTesting
{
    [TestClass]
    public class DALSach_Test
    {
        private DALSach dalSach;
        private Mock<QLTVDb> dbContextMock;
        private Mock<DbSet<SACH>> sachDbSetMock;

        [TestInitialize]
        public void Setup()
        {
            dbContextMock = new Mock<QLTVDb> ();
            sachDbSetMock = new Mock<DbSet<SACH>>();
            dalSach = new DALSach(dbContextMock.Object);

            var sachList = new List<SACH>
            {
                new SACH{id = 1, MaSach = "Sach001", idTuaSach = 1, SoLuong = 10, SoLuongConLai = 5, DonGia = 100000, NamXB = 2022, NhaXB = "Tuoi Tre", DaAn = 3},
                 new SACH{id = 2, MaSach = "Sach002", idTuaSach = 1, SoLuong = 10, SoLuongConLai = 5, DonGia = 100000, NamXB = 2022, NhaXB = "Tuoi Tre", DaAn = 3}
            };

            sachDbSetMock.As<IQueryable<SACH>>().Setup(m => m.Provider).Returns(sachList.AsQueryable().Provider);
            sachDbSetMock.As<IQueryable<SACH>>().Setup(m => m.Expression).Returns(sachList.AsQueryable().Expression);
            sachDbSetMock.As<IQueryable<SACH>>().Setup(m => m.ElementType).Returns(sachList.AsQueryable().ElementType);
            sachDbSetMock.As<IQueryable<SACH>>().Setup(m => m.GetEnumerator()).Returns(sachList.AsQueryable().GetEnumerator());

            dbContextMock.Setup(m => m.SACHes).Returns(sachDbSetMock.Object);
        }

        [TestMethod]
        public void Test_GetAllSach()
        {
            var result = dalSach.GetAllSach() as List<SACH>;

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void Test_GetSachByID()
        {
            var idSach = 1;
            var expectedSach = new SACH { id = 1, MaSach = "Sach001", idTuaSach = 1, SoLuong = 10, SoLuongConLai = 5, DonGia = 100000, NamXB = 2022, NhaXB = "Tuoi Tre", DaAn = 3 };

            dbContextMock.Setup(db => db.SACHes.Find(idSach)).Returns(expectedSach);

            var result = dalSach.GetSachById(idSach);

            Assert.AreEqual(expectedSach.id, result.id);
        
            
        }

        [TestMethod]
        public void Test_GetSachByMa()
        {
            var maSach = "Sach001";
            var expectedSach = new SACH { id = 1, MaSach = "Sach001", idTuaSach = 1, SoLuong = 10, SoLuongConLai = 5, DonGia = 100000, NamXB = 2022, NhaXB = "Tuoi Tre", DaAn = 3 };

            dbContextMock.Setup(db => db.SACHes.Find(maSach)).Returns(expectedSach);

            var result = dalSach.GetSachByMa(maSach);

            Assert.AreEqual(expectedSach.id, result.id);


        }

        [TestMethod]
        public void Test_AddSachMoi()
        {
            var sach = new SACH { id = 1, MaSach = "Sach001", idTuaSach = 1, SoLuong = 10, SoLuongConLai = 5, DonGia = 100000, NamXB = 2022, NhaXB = "Tuoi Tre", DaAn = 3 };

      
            int id = dalSach.AddSachMoi(sach);

            Assert.IsTrue(id > 0);

            dbContextMock.Verify(m => m.SACHes.Add(sach), Times.Once());
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

        }

        [TestMethod]
        public void Test_AddSachDaCo_IsTrue()
        {
            var sach = new SACH { id = 1, MaSach = "Sach001", idTuaSach = 1, SoLuong = 10, SoLuongConLai = 5, DonGia = 100000, NamXB = 2022, NhaXB = "Tuoi Tre", DaAn = 3 };
            dbContextMock.Setup(m => m.SACHes.Find(sach.id)).Returns(sach);

            var result = dalSach.AddSachDaCo(sach.id, 10);

            Assert.IsTrue(result);

            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);

        }

   
        [TestMethod]
        public void Test_AddSachDaCo_IsFalse()
        {
            var sach = new SACH { id = 3, MaSach = "Sach003", idTuaSach = 1, SoLuong = 10, SoLuongConLai = 5, DonGia = 100000, NamXB = 2022, NhaXB = "Tuoi Tre", DaAn = 3 };
            dbContextMock.Setup(m => m.SACHes.Find(sach.id)).Returns(sach);

            var result = dalSach.AddSachDaCo(99, 10);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_DelSach_ShouldDeleteExistingSach()
        {
            var existingSachId = 1;

            var sach = new SACH { id = 1, MaSach = "Sach001", idTuaSach = 1, SoLuong = 10, SoLuongConLai = 5, DonGia = 100000, NamXB = 2022, NhaXB = "Tuoi Tre", DaAn = 3 };
            dbContextMock.Setup(m => m.SACHes.Find(sach.id)).Returns(sach);

            bool result = dalSach.DelSach(existingSachId);
            Assert.IsTrue(result);

            sachDbSetMock.Verify(m => m.Remove(sach), Times.Once);
            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void Test_DelSach_ShouldReturnFalseForNonExistingSach()
        {
            var nonExistingSachId = 3;

            bool result = dalSach.DelSach(nonExistingSachId);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Test_UpdAnSach_ShouldUpdateExistingSachDaAn()
        {
            // Arrange
            var existingSachId = 1;
            var sach = new SACH { id = 1, MaSach = "Sach001", idTuaSach = 1, SoLuong = 10, SoLuongConLai = 5, DonGia = 100000, NamXB = 2022, NhaXB = "Tuoi Tre", DaAn = 3 };
            dbContextMock.Setup(m => m.SACHes.Find(sach.id)).Returns(sach);

            var newData = 1; 

            // Act
            bool result = dalSach.UpdAnSach(existingSachId, newData);

            // Assert
            Assert.IsTrue(result);

            dbContextMock.Verify(m => m.SaveChanges(), Times.Once);


        }

        [TestMethod]
        public void Test_UpdAnSach_ShouldReturnFalseForNonExistingSach()
        {
            // Arrange
            var existingSachId = 999;
          
            var newData = 1;

            // Act
            bool result = dalSach.UpdAnSach(existingSachId, newData);

            // Assert
            Assert.IsFalse(result);


        }


        [TestMethod]
        public void Instance_ShouldReturnSameInstance()
        {
            // Arrange
            var dbContextMock = new Mock<QLTVDb>();

            // Act
            var instance1 = DALSach.Instance;
            var instance2 = DALSach.Instance;

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
            var dalInstance = new DALSach(dbContextMock.Object);

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.AreSame(dbContextMock.Object, dalInstance.db);
        }

        [TestMethod]
        public void Constructor_WithoutDbContext_ShouldCreateDbContext()
        {
            // Act
            var dalInstance = new DALSach();

            // Assert
            Assert.IsNotNull(dalInstance);
            Assert.IsNotNull(dalInstance.db);
        }

        [TestMethod]
        public void DelPhieuMuonTra_ShouldReturnFalseOnException()
        {
            // Arrange
            var soPhieu = 99;

            var mockRepository = new MockRepository(MockBehavior.Default);
            var bcMock = mockRepository.Create<SACH>();

            // Create a mock DbContext
            var dbContextMock = mockRepository.Create<QLTVDb>();

            dbContextMock.Setup(db => db.SaveChanges()).Throws(new Exception("Simulated exception"));

            var sut = new DALSach(dbContextMock.Object);

            // Act
            var result = sut.DelSach(soPhieu);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
