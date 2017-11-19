using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sort
{
    class Program
    {
        public static Stopwatch treeclock = new Stopwatch();
        public static Stopwatch mergeclock = new Stopwatch();
        public static Stopwatch bubbleclock = new Stopwatch();
        public static int[] numbers = new int[10000];
        public static int[] treesorted_array = new int[10000];
        public static int[] mergersorted_array = new int[10000];
        public static int[] bubblesorted_array = new int[10000];
        static void Main(string[] args)
        {
            build_array();
            tree_sort();
            merge_sort();
            bubble_sort();
            print();
        }
        public static void build_array()
        {
                      
            Random random = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 10000);
                
            }           
        }
        public static void tree_sort()
        {
            treeclock.Start();
            Binary_tree_sort tree = new Binary_tree_sort();
            treesorted_array = tree.get_array(numbers);
            treeclock.Stop();
        }
        public static void merge_sort()
        {
            mergeclock.Start();
            MergeSorter merge = new MergeSorter();
            mergersorted_array = merge.domergesort(numbers);
            mergeclock.Stop();
        }
        public static void bubble_sort()
        {
            bubbleclock.Start();
            Bubble_Sorter bubble = new Bubble_Sorter();
            bubblesorted_array = bubble.bubblesort(numbers);
            bubbleclock.Stop();
        }
        public static void print()
        {
            TimeSpan t = treeclock.Elapsed;
            TimeSpan m = mergeclock.Elapsed;
            TimeSpan b = bubbleclock.Elapsed;
            Console.WriteLine("Binary Tree\t"+ t +"\nMerge Sort\t"+m+ "\nBubble Bort\t"+b);
            Console.ReadLine();
            Console.WriteLine("|Binary Tree |merge Sort |Bubble Bort");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(mergersorted_array[i] + "\t\t" + treesorted_array[i] + "\t\t" +bubblesorted_array[i]);
            }
            
            Console.Read();
        }
    }
}
