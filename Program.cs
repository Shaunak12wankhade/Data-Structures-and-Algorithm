using System;
using System.IO;

namespace DataStructuresandAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Datastructures and Algorithms");


            // BinarySearchWord

            //BinarySearchword dataStructure = new BinarySearchword();
            //string[] words = { "decs", "read", "logic", "search" };
            //string data = "search";
            //int result = dataStructure.FindWord(words, data);
            //if (result == -1)
            //    Console.WriteLine("Word not present");

            //else
            //    Console.WriteLine("Word is found at " + result);




            //BubbleSort

            //Bubblesort dataStructure = new Bubblesort();
            //dataStructure.BubbleSort();


            //InsertionSort


            //string[] names = { "One", "Two", "Four", "Six" };
            //InsertionSort dataStructure = new InsertionSort();
            //dataStructure.Insertion(names);


            //AnagramDetection


            //Datastructurealgorithm datastructure = new Datastructurealgorithm();
            // datastructure.Anagram();




            //NumberOfBinarySearchTree

            NumberOfBinarySearchTree<string> dataStructure = new NumberOfBinarySearchTree<string>();
            dataStructure.Prime();


        }
    }
}
