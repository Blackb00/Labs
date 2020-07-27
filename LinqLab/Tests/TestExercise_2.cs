using System;
using System.Collections.Generic;
using System.Linq;
using LinqLabLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TestExercise_2
    {
        [TestMethod]
        public void ShouldConcatinate()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);

            //Act
            IEnumerable<INamed> result = CInteractor_2.GetConcatinate(returnedArray.Take(100), returnedArray.Skip(100));

            //Assert
            Assert.IsTrue(result.Count()==240);
        }

        [TestMethod]
        public void ShouldGroupingByLastNumOfCode()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);

            //Act
            IEnumerable<IGrouping<Char,INamed>> result = CInteractor_2.GetGroupedByLastNumberOfCode(returnedArray);

            //Assert
            Assert.IsTrue(result.First().Key == '0');
            Assert.IsTrue(result.First().Count() == 47);
        }

    }
}
