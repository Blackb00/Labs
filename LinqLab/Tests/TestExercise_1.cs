using System;
using System.Collections.Generic;
using System.Linq;
using LinqLabLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tests
{
    [TestClass]
    public class TestExercise_1
    {
        [TestMethod]
        public void ShouldReadFromFile()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            //Act
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);
            //Assert
            Assert.IsTrue(returnedArray.Count == 240);
        }


        [TestMethod]
        public void ShouldPerformSelectionByName()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);

            //Act
            IEnumerable<String> names = CInteractor_1.SelectNames(returnedArray);

            //Assert
            Assert.AreEqual(names.First(), "AALAND ISLANDS");
            Assert.AreEqual(names.Last(), "ZIMBABWE");

        }

        [TestMethod]
        public void ShouldPerformSelectionByCode()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);

            //Act
            IEnumerable<String> codes = CInteractor_1.SelectCodes(returnedArray);

            //Assert
            Assert.AreEqual(codes.First(), "ALA");
            Assert.AreEqual(codes.Last(), "ZWE");

        }

        [TestMethod]
        public void ShouldPerformSelectionByCodeNumber()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);

            //Act
            IEnumerable<String> codes = CInteractor_1.SelectNumerics(returnedArray);

            //Assert
            Assert.AreEqual(codes.First(), "248");
            Assert.AreEqual(codes.Last(), "716");

        }

        [TestMethod]
        public void ShouldPerformFiltrationByName()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);

            //Act
            IEnumerable<INamed> objects = CInteractor_1.GetFilteredByName(returnedArray, "a");

            //Assert
            Assert.IsTrue(objects.Count()==16);
        }

        [TestMethod]
        public void ShouldPerformOrderingByNameLength()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);

            //Act
            IEnumerable<INamed> objects = CInteractor_1.GetOrderedByNameLength(returnedArray);

            //Assert
            Assert.AreEqual(objects.First().Name, "CHAD");
            Assert.AreEqual(objects.Last().Name, "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS");
        }

        [TestMethod]
        public void ShouldPerformOrderingByNameLengthAndCodeNumber()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);

            //Act
            IEnumerable<INamed> objects = CInteractor_1.GetOrderedByNameLengthAndNum(returnedArray);

            //Assert
            Assert.AreEqual(objects.First().Name, "CHAD");
            Assert.AreEqual(objects.Last().Name, "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS");
        }

        [TestMethod]
        public void ShouldPerformSelectionFiltrationAndOrdering()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);

            //Act
            IEnumerable<String> names = CInteractor_1.GetSelectedSortedOrdered(returnedArray,"a");

            //Assert
            Assert.IsTrue(names.Count() == 16);
            Assert.AreEqual(names.First(), "AZERBAIJAN");
            Assert.AreEqual(names.Last(), "AALAND ISLANDS");
        }

    }
}
