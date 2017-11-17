using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            build_array();
        }
        public static void build_array()
        {
            int[] numbers = new int[10];            
            Random random = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
                
            }
            foreach(int n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.Read();
        }
    }
}
