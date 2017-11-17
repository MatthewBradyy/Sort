using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        public static int[] numbers = new int[10];
        static void Main(string[] args)
        {
            build_array();
            send_array();
        }
        public static void build_array()
        {
                        
            Random random = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
                
            }            
        }
        public static void send_array()
        {
            Binary_tree_sort tree = new Binary_tree_sort();
            foreach (int n in numbers)
            {
                tree.get_array(n);
            }
            tree.sort();
        }

    }
}
