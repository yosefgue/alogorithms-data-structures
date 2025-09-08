using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    public static class SelectionSort
    {
        public static int[] SortList(int[] anarray)
        {
            for (int i = 0; i < anarray.Length; i++)
            {
                int smallestindex = i;
                for (int j = i + 1 ; j < anarray.Length; j++)
                {
                    if (anarray[smallestindex] > anarray[j])
                    {
                        smallestindex = j;
                    }
                }
                int temp = anarray[i];
                anarray[i] = anarray[smallestindex];
                anarray[smallestindex] = temp;
            }
            return anarray;
        }
    }
}
