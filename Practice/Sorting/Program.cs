using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class Program
    {
        public static InsertionSort insertion = new InsertionSort();
        public static QuickSort quick = new QuickSort();
        public static MergeSort merge = new MergeSort();

        public static void Main(string[] args)
        {
            var a1 = KLD.OneMillion;
            var a2 = KLD.OneMillion;
            var a3 = KLD.OneMillion;

            try
            {
                Console.WriteLine("INSERTION SORT");
                KLD.StartTimer();
                insertion.Sort(ref a1);
                KLD.StopTimer();
            }
            catch
            {
                Console.WriteLine("Error encountered");
            }

            try
            {
                Console.WriteLine("\nQUICK SORT");
                KLD.StartTimer();
                quick.Sort(ref a1);
                KLD.StopTimer();
            }
            catch
            {
                Console.WriteLine("Error encountered");
            }

            try
            {
                Console.WriteLine("\nMERGE SORT");
                KLD.StartTimer();
                merge.Sort(ref a1);
                KLD.StopTimer();
            }
            catch
            {
                Console.WriteLine("Error encountered");
            }

            Console.WriteLine("\nThe End");
            Console.ReadLine(); 
        }
    }
}
