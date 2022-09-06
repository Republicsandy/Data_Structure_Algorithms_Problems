using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAlgorithmsProblem
{
    internal class InsertionSort
    {
        public static void sort()
        {
            // string array 
            string[] Name_list = { "sandy", "ajay", "prasoon", "pravin", "priti", "darshan" };
            //storing array value in insert sort method
            InsertSort(Name_list);
            //foreachloop
            foreach (var name_item in Name_list)
                Console.WriteLine(name_item);
        }
        static void InsertSort(IComparable[] array)
        {
            // instance variablex
            int array_i, array_j;
            /*storing current element whose left side is checked for its correct position .*/
            for (array_i = 1; array_i < array.Length; array_i++)
            {
                /* check whether the adjacent element in left side is greater or
                  less than the current element.  */
                IComparable value = array[array_i];
                array_j = array_i - 1;
                /* check whether the adjacent element in left side is greater or
                  less than the current element.  */
                while ((array_j >= 0) && (array[array_j].CompareTo(value) > 0))
                {
                    // moving the left side element to one position forward.
                    array[array_j + 1] = array[j];
                    array_j--;
                }
                // moving current element to its  correct position.

                array[array_j + 1] = value;
            }
        }
    }
}
