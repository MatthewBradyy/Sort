using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class MergeSorter
    {
        public int[] domergesort(int[] reseved)
        {
            int[] sortednumber = mergeSort(reseved);
            return sortednumber;
        }
        public static int[] mergeSort(int[] numbers)
        {
            //if array only has 1 number
            if(numbers.Length <= 1)
            {
                return numbers;
            }
            var left = new List<int>();
            var right = new List<int>();
            for(int i = 0; i <numbers.Length; i++)
            {
                if (i % 2 > 0)
                {
                    left.Add(numbers[i]);
                }
                else
                {
                    right.Add(numbers[i]);
                }
            }
            left = mergeSort(left.ToArray()).ToList();
            right = mergeSort(right.ToArray()).ToList();
            return merge(left, right);
        }
        public static int[] merge(List<int> left ,List<int> right)
        {
            List<int> result = new List<int>();
            while(left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right.First())
                {
                    remove(left, result);
                }
                else
                {
                    remove(right, result);
                }
            }
            while(left.Count() > 0)
            {
                remove(left, result);
            }
            while (right.Count() > 0)
            {
                remove(right, result);
            }
            return result.ToArray();
        }

        private static void remove(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
    }
}
