using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithmsProblem
{
    internal class Permutation
    {
        public static void Permute(String str, int startingIndex, int endIndex)
        {
            //if startindex ==  endindex print str
            if (startingIndex == endIndex)
                Console.WriteLine(str);
            else
            {

                for (int var_i = startingIndex; var_i <= endIndex; var_i++)
                {
                    str = Swap(str, startingIndex, var_i);
                    Permute(str, startingIndex + 1, endIndex);
                    str = Swap(str, startingIndex, var_i);
                }
            }
        }
        public static string Swap(string inputForWord, int left, int var_i)
        {
            char temp;
            char[] charArray = inputForWord.ToCharArray();
            temp = charArray[left];
            charArray[left] = charArray[var_i];
            charArray[var_i] = temp;
            string Output = new string(charArray);
            return Output;
        }
    }
}
