using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10,20, 30,40,50};
            int sum = 0;
 
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of all the elements of an array: " + sum);
            Console.ReadLine();
        }
    }
}
