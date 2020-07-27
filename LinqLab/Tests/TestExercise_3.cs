using System;
using System.Collections.Generic;
using System.Linq;
using LinqLabLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TestExercise_3
    {
        [TestMethod]
        public void ShouldJoin()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);
            IEnumerable<CNamed> namedObjs = returnedArray.Select(x => new CNamed()
            {
                Name = x.Name,
                Code = x.Code
            });
            IEnumerable<CNumeric> numObjs = returnedArray.Select(x => new CNumeric()
            {
                Numeric = x.Numeric,
                Code = x.Code
            });

            //Act
            var result = CInteractor_3.GetJoined(namedObjs, numObjs);

            //Assert
            Assert.IsTrue(result.First().Name==returnedArray.First().Name &&
                          result.First().Code == returnedArray.First().Code &&
                          result.First().Numeric == returnedArray.First().Numeric);
        }

        [TestMethod]
        public void ShouldUnion()
        {
            //Arrange
            String _path = "./../../Countries.txt";
            List<INamed> returnedArray = CService.ReadFromTextFile(_path);
            IEnumerable<INamed> firstObjs = returnedArray.Take(100);
            IEnumerable<INamed> secondObjs = returnedArray.Skip(70);

            //Act
            var result = CInteractor_3.GetUnited(firstObjs, secondObjs);

            //Assert
            Assert.IsTrue(result.Count() == returnedArray.Count);
        }
    }
}
