using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithmsProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Problems");
            Console.WriteLine("Press 1 for Bubble Sort Problem");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    var Output = new BubbleSort(10);
                    Random random = new Random(20);
                    for (int i = 0; i < 10; i++)
                        Output.InsertNumbers((int)(random.NextDouble() * 10));
                    Console.WriteLine("Before sorting:");
                    Output.DisplayElements();
                    Console.WriteLine("During sorting:");
                    Output.BubbleSorts();
                    Console.WriteLine("After sorting:");
                    Output.DisplayElements();
                    break;
                case 2:
                    InsertionSort.sort();
                    break;
                case 3:
                    Permutation permutation = new Permutation();
                    String str = "Shreya";
                    int Outputs = str.Length;
                    Permutation.Permute(str, 0, Outputs - 1);
                    break;
                case 4:
                    Anagram anagram = new Anagram();
                    anagram.Check();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Enter a valid option:");
                    break;
            }
        }
    }
}
