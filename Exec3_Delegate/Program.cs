using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec3_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> items = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            
            List<int> EvenItems = GetEvenItems(items, n => n % 2 == 0);
           
            foreach (int item in EvenItems)
            {
                Console.WriteLine(item);
            }


        }
        static List<int> GetEvenItems(List<int> items, Func<int, bool> func)
        {
            var value = new List<int>();

            foreach (int item in items)
            {
                if (func(item) == true)
                {
                    value.Add(item);
                }
            }

            return value;
        }
    }
}
