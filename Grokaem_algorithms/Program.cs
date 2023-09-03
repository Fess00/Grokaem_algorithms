using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokaem_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] unSortedArr = { 12, 1, 5, 3, 7, 9, 8, 4, 10, 11, 6, 2 };
            int[] qsortTest = new int[unSortedArr.Length];
            unSortedArr.CopyTo(qsortTest, 0);
            int index = GrokaemAlgo.BinarySearch(arr, 9);
            GrokaemAlgo.SelectionSort(unSortedArr);

            Console.WriteLine(index);

            foreach (var item in unSortedArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine(GrokaemAlgo.RecursiveSum(new int[] { 100, 100, 100 }));

            GrokaemAlgo.QSort(qsortTest);

            foreach (var item in qsortTest)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            HashTable<int, string> table = new HashTable<int, string>(32);
            Console.WriteLine(table.Size);
            table[0] = "Dance";
            Console.WriteLine(table[0]);
            Console.WriteLine(table.Size + " " + table.Capacity);
            table[1] = "Sens";
            Console.WriteLine(table[1]);
            Console.WriteLine(table.Size + " " + table.Capacity);

            Listing<int> listing = new Listing<int>();
            listing.SetItem(3, 0);
            Console.WriteLine(listing[0].Item);
            listing.Add(6);
            Console.WriteLine(listing[1].Item);
            listing.Add(9);
            Console.WriteLine(listing[2].Item);
            listing.Add(12);
            Console.WriteLine(listing[3].Item);

            GraphNode<int> graph = new GraphNode<int>(1, 1, 
                new GraphNode<int>(3, 2, 
                    new GraphNode<int>(0, 4),
                    new GraphNode<int>(0, 5),
                    new GraphNode<int>(1, 6, 
                        new GraphNode<int>(0, 7))));

            Console.WriteLine(true ? 9 : 6);

            Console.WriteLine(GrokaemAlgo.BFSearch(graph, 7)); ;
        }
    }
}
