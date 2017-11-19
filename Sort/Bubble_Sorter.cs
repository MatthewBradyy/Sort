using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Bubble_Sorter
    {

        public int[] dobublsort(int[] reseved)
        {
            int[] sortednumber = bubblesort(reseved);            
            return sortednumber;
        }
        public int[] bubblesort(int[] list)
        {
            for (int y = 0; y <= list.Length - 1; y++)
            {
                for (int i = 0; i <= list.Length - 2; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
            }
            return list;
        }
        
    }
}
