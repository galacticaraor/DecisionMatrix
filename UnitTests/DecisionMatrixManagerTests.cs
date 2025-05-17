using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class DecisionMatrixManagerTests
    {
        private List<DecisionMatrix> Load()
        {
            List<DecisionMatrix> dm = new List<DecisionMatrix>();
            dm.Add(new DecisionMatrix("1") { Name = "name1" });
            dm.Add(new DecisionMatrix("2") { Name = "name2" });
            dm.Add(new DecisionMatrix("3") { Name = "name3" });
            return dm;
        }

        [TestMethod()]
        public void Search_NoKeyword_All()
        {
            //Arrange
            var mock = new Mock<IStorage>();
            mock.Setup(m => m.LoadDecisionMatrixes()).Returns(Load());
            DecisionMatrixManager manager = new DecisionMatrixManager(mock.Object);
            //Act
            List<DecisionMatrix> dm = manager.Search("");
            //Assert
            Assert.AreEqual(3, dm.Count);
        }

        [TestMethod()]
        public void Search_Keyword_Some()
        {
            //Arrange
            var mock = new Mock<IStorage>();
            mock.Setup(m => m.LoadDecisionMatrixes()).Returns(Load());
            DecisionMatrixManager manager = new DecisionMatrixManager(mock.Object);
            //Act
            List<DecisionMatrix> dm = manager.Search("1");
            //Assert
            Assert.AreEqual(1, dm.Count);
        }

        [TestMethod()]
        public void Add_Nominal_Added()
        {
            //Arrange
            var mock = new Mock<IStorage>();
            List<DecisionMatrix> dm = Load();
            mock.Setup(m => m.LoadDecisionMatrixes()).Returns(dm);
            mock.Setup(m => m.SaveDecisionMatrixes(dm)).Returns(new FileResult(true, ""));
            DecisionMatrixManager manager = new DecisionMatrixManager(mock.Object);
            //Act
            FileResult fileResult = manager.Add(new DecisionMatrix("4") { Name = "name4" });
            //Assert
            Assert.AreEqual(true, fileResult.Successful);
        }

        [TestMethod()]
        public void Edit_Nominal_Edited()
        {
            //Arrange
            var mock = new Mock<IStorage>();
            List<DecisionMatrix> dm = Load();
            mock.Setup(m => m.LoadDecisionMatrixes()).Returns(dm);
            mock.Setup(m => m.SaveDecisionMatrixes(dm)).Returns(new FileResult(true, ""));
            DecisionMatrixManager manager = new DecisionMatrixManager(mock.Object);
            //Act
            FileResult fileResult = manager.Edit(new DecisionMatrix("1") { Name = "Matrix 1" });
            //Assert
            Assert.AreEqual(true, fileResult.Successful);
        }

        [TestMethod()]
        public void Delete_Nominal_Deleted()
        {
            //Arrange
            var mock = new Mock<IStorage>();
            List<DecisionMatrix> dm = Load();
            mock.Setup(m => m.LoadDecisionMatrixes()).Returns(dm);
            mock.Setup(m => m.SaveDecisionMatrixes(dm)).Returns(new FileResult(true, ""));
            DecisionMatrixManager manager = new DecisionMatrixManager(mock.Object);
            //Act
            FileResult fileResult = manager.Delete("3");
            //Assert
            Assert.AreEqual(true, fileResult.Successful);
        }

        [TestMethod()]
        public void Get_NotFound_Blank()
        {
            var mock = new Mock<IStorage>();
            List<DecisionMatrix> dm = Load();
            mock.Setup(m => m.LoadDecisionMatrixes()).Returns(dm);
            mock.Setup(m => m.SaveDecisionMatrixes(dm)).Returns(new FileResult(true, ""));
            DecisionMatrixManager manager = new DecisionMatrixManager(mock.Object);
            //Act
            DecisionMatrix decisionMatrix = manager.Get("0");
            //Assert
            Assert.AreEqual("", decisionMatrix.Name);
        }

        [TestMethod()]
        public void Get_Found_Initialized()
        {
            var mock = new Mock<IStorage>();
            List<DecisionMatrix> dm = Load();
            mock.Setup(m => m.LoadDecisionMatrixes()).Returns(dm);
            mock.Setup(m => m.SaveDecisionMatrixes(dm)).Returns(new FileResult(true, ""));
            DecisionMatrixManager manager = new DecisionMatrixManager(mock.Object);
            //Act
            DecisionMatrix decisionMatrix = manager.Get("1");
            //Assert
            Assert.AreEqual("name1", decisionMatrix.Name);
        }
    }
}