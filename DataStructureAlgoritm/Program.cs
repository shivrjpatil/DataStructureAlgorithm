using System;
namespace DataStructureAlgoritm
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to data structure algoritm");
            BinarySearch binary=new BinarySearch();
            binary.ReadTextFile("C:\\Users\\shiv\\Desktop\\git repositary\\DataStructureAlgoritm\\Files");
            binary.BinarySearchOperation("code");

        }
    }
}