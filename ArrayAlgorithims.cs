using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_Prep
{
    public class ArrayAlgorithims
    {

        public int SequentialSearch(string[] inputarr, string value)
        {
            bool found = false;

            int i = 0;

            int position = -1;

            while (!found && i < inputarr.Length)
            {
                if (inputarr[i] == value)
                {
                    found = true;
                    position = i; break;
                }
                else
                {
                    i++;
                }
            }

            return position;
        }

        //overloaded for integer
        public int SequentialSearch(int[] inputArr, int value)
        {
            bool found = false;

            int i = 0;

            int position = -1;

            while (!found && i < inputArr.Length)
            {
                if (inputArr[i] == value)
                {
                    found = true;
                    position = i; break;
                }
                else
                {
                    i++;
                }
            }

            return position;
        }

        public int[] CopyArray(int[] inputarr)
        {
            int[] arrayCopy = new int[inputarr.Length];

            for (int i = 0; i <= inputarr.Length -1; i++)
            {
                arrayCopy[i] = inputarr[i];
            }

            return arrayCopy;
        }


        public bool CompareArrays(int[] array1, int[] array2)
        {
            if(array1.Length != array2.Length)
            {
                return false;
            }


            bool equal = true;
            int i = 0;
            while(equal && i < array1.Length)
            {
                if(array1[i] != array2[i])
                {
                    equal = false;
                }
                i++;
            }
            return equal;
        }

        public int Sum(int[] array)
        {
            int total = 0;

            foreach (int i in array)
            {
                total += i;
            }

            return total;
        }

        public double Average(int[] array)
        {
            double average = 0;

            foreach (int i in array)
            {
                average += i;
            }

            average = average / array.Length;

            return average;
        }

        public int FindHighest(int[] array)
        {
            int highest = array[0];

            foreach (int i in array)
            {
                if (i > highest)
                {
                    highest = i;
                }
            }

            return highest;
        }

        public int FindLowest(int[] array)
        {
            int lowest = array[0]; 

            foreach (int i in array)
            {
                if (i < lowest)
                {
                    lowest = i;
                }
            }

            return lowest;
        }


    }
}
