using Microsoft.VisualStudio.TestTools.UnitTesting;
using AoCday3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoCday3.Tests
{
    [TestClass()]
    public class FileReaderTests
    {
        [TestMethod()]
        public void ReadFromFileTestShouldReturnIntArray()
        {

            //given
            FileReader reader = new FileReader();

            //when
            string[] readedArray = reader.ReadFromFile();
            //then     
            Assert.IsInstanceOfType(readedArray, typeof(string[]), "something went wrong, wrong arrayType");
        }

        [TestMethod()]
        public void arrayParserTestShouldReturnListWithArrays()
        {
            //
            FileReader reader = new FileReader();

            //
            List<int[]> intList = reader.arrayParser(reader.ReadFromFile());
            //
            Assert.IsInstanceOfType(intList, typeof(int[]), "wrong type");
            Assert.IsTrue(intList.Any(), "sry, List is empty");
        }
    }
}