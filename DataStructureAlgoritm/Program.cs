using System;
namespace DataStructureAlgoritm
{
    class program
    {
        public static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            { 
             Console.WriteLine("DATA STRUCTURES AND ALGORITM");
             Console.WriteLine("enter the option to select");
             int option=Convert.ToInt32(Console.ReadLine());
            
            
                switch (option)
                {
                    case 1:
                        InsertionSort sort = new InsertionSort();
                        int[] arr = { 20, 39, 2, 3, 6, 54, 3 };
                        sort.Sort(arr);
                        break;
                    case 2:
                        BubbleSort bubbleSort = new BubbleSort();
                        int[] arrr = { 6, 3, 4, 27, 8 };
                        bubbleSort.Sort(arrr);
                        break;
                    case 3:
                        Anagram check = new Anagram();
                        check.CheckAnagram("heart", "earth");
                        break;
                    case 4:
                        UserInput input = new UserInput();
                        input.ReplaceString();
                        break;
                    case 5:
                        Console.WriteLine("Enter the word you want to Search");
                        BinarySearch binary = new BinarySearch();
                        binary.ReadTextFile(@"C:\Users\shiv\Desktop\git repositary\DataStructureAlgorithm\DataStructureAlgoritm\Files\BinaySearch.txt");
                        binary.BinarySearchOperation("hello");
                        
                        break;
                    default:
                        Console.WriteLine("you have entered wrong option");
                        break;
                }
            }
        }
    }
}