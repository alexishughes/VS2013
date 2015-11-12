using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inversionsTimRoughgardenCSharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class arrayToSort
    {
        public int[] intA;
        public int[] intB;
        public int[] intC;
        public int[] intD;
        public int intLenA;
        public int intLenB;
        public int intLenC;
        public arrayToSort(int[] A)
        {
            intLenA = A.Length;
            intA = A;
        }
        public int divideAndConquer()
        {
            intLenB = intLenA / 2;
            intB = new int[intLenB];
            intLenC = intLenA - intLenB;
            intC = new int[intLenC];

            for(int i=0;i<intLenB;i++)
            {
                intB[i] = intA[i];
            }
            int j=0;
            for (int i = intLenB + 1; i < intLenA; i++)
            {
                intC[j] = intA[i];
                j++;
            }
            return 0;
        }
        public int recursiveSort()
            {
            arrayToSort arrB = new arrayToSort(intB);
            arrayToSort arrC = new arrayToSort(intC);
            recursiveSort arrB;
                recursiveSort arrC;
                return 0;
            }


        }

    }
}
