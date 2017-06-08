using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AoCday3
{
    public class FileReader
    {

        private string _filepath = @"D:\input data\AoCday3.txt";

        public string[] ReadFromFile()
        {

            string[] stringArray = File.ReadAllLines(_filepath);

            //int[] intArray = Array.ConvertAll(stringArray, int.Parse);

            return stringArray;

        }

        public List<int[]> arrayParser(string[] inputArray)
        {
            List<int[]> parsedArrays = new List<int[]>();

            foreach (var line in inputArray)
            {
                string[] stringArray = Regex.Split(line, @"\s");
                

                int[] intArray =  Array.ConvertAll(stringArray, int.Parse);
                parsedArrays.Add(intArray);
            }
            return parsedArrays;
        }

    }
}
