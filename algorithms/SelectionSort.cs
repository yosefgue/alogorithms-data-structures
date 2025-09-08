using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    public static class SelectionSort
    {
        public static int Smallest(List<int> anarray)
        {
            int smallestint = anarray[0];
            int smallestintindex = 0;
            for (int i = 1; i < anarray.Count; i++ )
            {
                if (smallestint > anarray[i])
                {
                    smallestint = anarray[i];
                    smallestintindex = i;
                }
            }
            return smallestintindex;
        }
        public static int[] Sort(int[] anarray)
        {
            List<int> copyarray = anarray.ToList();
            List<int> list = new List<int> ();
            for (int i = 0;  i < anarray.Length; i++ )
            {
                int smallestint = copyarray[Smallest(copyarray)];
                list.Add(smallestint);
                copyarray.Remove(smallestint);
            }
            return list.ToArray();
        }
    }
}
