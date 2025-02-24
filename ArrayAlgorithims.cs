using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook_Prep
{
    public class ArrayAlgorithims
    {
        /// <summary>
        /// Search the value of any giving string array
        /// </summary>
        /// <param name="inputArray">array</param>
        /// <param name="valueToSearch">value to search</param>
        /// <returns>Returns the position of the found value or -1 if it is not found</returns>  
        public int SequentialSearch(string[] inputArray, string valueToSearch)
        {
            bool found = false;

            int i = 0;

            int position = -1;

            while (!found && i < inputArray.Length)
            {
                if (inputArray[i] == valueToSearch)
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

        
        public int[] SelectionSort(int[] array)
        {
            int minIndex;
            int minValue;
            
            for (int startScan = 0; startScan < array.Length - 1; startScan++)
            {
                minIndex = startScan;

                minValue = array[minIndex];

                for(int index = startScan; index < array.Length; index++)
                {
                    if(array[index] < minValue)
                    {
                        minValue = array[index];
                        minIndex = index;
                    }
                }

                Swap(ref array[minIndex], ref array[startScan]);

            }

            return array;
        }

        private void Swap(ref int a, ref int b)
        {
            int temp = a;

            a = b;

            b = temp;
        }
    }
}
