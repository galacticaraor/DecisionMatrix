using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class DecisionMatrixTests
    {
        [TestMethod()]
        public void AddPro_Nominal_Added()
        {
            //Arrange
            DecisionMatrix dm = new DecisionMatrix();
            //Act
            dm.AddPro(new Factor("UUID", "Name1", 1));
            dm.AddPro(new Factor("UUID", "Name1", 2));
            //Assert
            Assert.AreEqual(3, dm.ProWeight);
        }

        [TestMethod()]
        public void EditPro_Nominal_Edited()
        {
            //Arrange
            DecisionMatrix dm = new DecisionMatrix();
            dm.Pros.Add(new Factor("1", "Name1", 1));
            dm.Pros.Add(new Factor("2", "Name1", 2));
            //Act
            dm.EditPro(new Factor("1", "Name1", 3));
            //Assert
            Assert.AreEqual(5, dm.ProWeight);
        }

        [TestMethod()]
        public void DeletePro_Nominal_Deleted()
        {
            //Arrange
            DecisionMatrix dm = new DecisionMatrix();
            dm.Pros.Add(new Factor("1", "Name1", 3));
            dm.Pros.Add(new Factor("2", "Name1", 3));
            //Act
            dm.DeletePro("2");
            //Assert
            Assert.AreEqual(3, dm.ProWeight);
        }

        [TestMethod()]
        public void AddCon_Nominal_Added()
        {
            //Arrange
            DecisionMatrix dm = new DecisionMatrix();
            //Act
            dm.AddCon(new Factor("UUID", "Name1", 1));
            dm.AddCon(new Factor("UUID", "Name1", 2));
            //Assert
            Assert.AreEqual(3, dm.ConWeight);
        }

        [TestMethod()]
        public void EditCon_Nominal_Edited()
        {
            //Arrange
            DecisionMatrix dm = new DecisionMatrix();
            dm.Cons.Add(new Factor("1", "Name1", 1));
            dm.Cons.Add(new Factor("2", "Name1", 2));
            //Act
            dm.EditCon(new Factor("1", "Name1", 3));
            //Assert
            Assert.AreEqual(5, dm.ConWeight);
        }

        [TestMethod()]
        public void DeleteCon_Nominal_Deleted()
        {
            //Arrange
            DecisionMatrix dm = new DecisionMatrix();
            dm.Cons.Add(new Factor("1", "Name1", 3));
            dm.Cons.Add(new Factor("2", "Name1", 3));
            //Act
            dm.DeleteCon("2");
            //Assert
            Assert.AreEqual(3, dm.ConWeight);
        }
    }
}