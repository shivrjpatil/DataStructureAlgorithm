using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgoritm
{
    public class BinarySearch
    {
        string[] binaryArr;
        public void ReadTextFile(string filePath)
        {
            string words = File.ReadAllText(filePath);
            binaryArr = words.Split(",");
        }
        public void BinarySearchOperation(string input)
        {
            foreach(var word in binaryArr)
            {
                if (word.Equals(input))
                {
                    Console.WriteLine("found the word");
                    return;
                }
            }
            Console.WriteLine("search element is not in available");

        }
        public void Display()
        {
            foreach (var data in binaryArr)
            {
                Console.WriteLine(data);
            }
        }
    }
}
