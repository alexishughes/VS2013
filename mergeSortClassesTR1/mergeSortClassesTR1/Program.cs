using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeSortClassesTR1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class arrToSort
    {
        public int[] intA;
        public int[] intB;
        public int[] intC;

        public ArraySort(int[] arrayToSort)
        {
            intA = arrayToSort;
            if intA.Length = 1
            
            
            int[] intB = new int[intA.Length / 2];
            for (int i = 0; i < intA.Length; i++)
            {
                intB[i] = intA[i];
            }
            int[] intC = new int[intA.Length - intA.Length / 2];
            for (int i = 0; i < intC.Length; i++)
            {
                intC[i] = intA[i + intA.Length / 2];
            }

            arrToSort arrA = new arrToSort(intA);
            arrToSort arrB = new arrToSort(intB);


        }
    }
}
