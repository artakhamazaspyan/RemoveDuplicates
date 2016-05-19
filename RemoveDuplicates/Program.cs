using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicates
{
    public class Program
    {
        private static readonly int[] RandomIntegers = {1,2,34,34,25,1,45,3,26,85,4,34,86,25,43,2,1,10000,11,16,19,1,18,4,9,3,
                                   20,17,8,15,6,2,5,10,14,12,13,7,8,9,1,2,15,12,18,10,14,20,17,16,3,6,19,
                                   13,5,11,4,7,19,16,5,9,12,3,20,7,15,17,10,6,1,8,18,4,14,13,2,11};   

        public static void Main(string[] args)
        {
            RemoveDuplicatesMethodFirst(RandomIntegers);
            RemoveDuplicatesMethodSecond(RandomIntegers);
            RemoveDuplicatesMethodThird(RandomIntegers);
        }

        public static List<int> RemoveDuplicatesMethodFirst(int[] randomIntegers)
        {
            var start = DateTime.Now;
            var result = new List<int>();
            foreach (var number in randomIntegers.Where(number => !result.Contains(number)))
            {
                result.Add(number);
            }
            Console.WriteLine("RemoveDuplicatesMethodFirst runtime is {0} ticks", (DateTime.Now - start).TotalMilliseconds);
            Console.WriteLine("RemoveDuplicatesMethodFirst result:");
            Console.Write("[");
            var count = 0;
            foreach (var item in result)
            {
                Console.Write(item);
                count++;
                if (result.Count > count)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
             
            return result;
        }

        public static List<int> RemoveDuplicatesMethodSecond(int[] randomIntegers)
        {
            var start = DateTime.Now;
            var result = randomIntegers.Distinct().ToList();
            Console.WriteLine("RemoveDuplicatesMethodSecond runtime is {0} ticks", (DateTime.Now - start).TotalMilliseconds);
            Console.WriteLine("RemoveDuplicatesMethodSecond result:");
            Console.Write("[");
            var count = 0;
            foreach (var item in result)
            {
                Console.Write(item);
                count++;
                if (result.Count > count)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
            return result;
        }

        public static List<int> RemoveDuplicatesMethodThird(int[] randomIntegers)
        {
            var start = DateTime.Now;
            var result = new HashSet<int>(randomIntegers).ToList();

            Console.WriteLine("RemoveDuplicatesMethodThird runtime is {0} ticks", (DateTime.Now - start).TotalMilliseconds);
            Console.WriteLine("RemoveDuplicatesMethodThird result:");
            Console.Write("[");
            var count = 0;
            foreach (var item in result)
            {
                Console.Write(item);
                count++;
                if (result.Count > count)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("]");
            
            return result;
        }
    }
}
