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
    }
}