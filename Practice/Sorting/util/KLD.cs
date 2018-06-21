using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SortingAlgorithms
{
    public class KLD
    {
        public static int[] Generate(int n)
        {
            int[] list = Enumerable.Range(0, n).ToArray();

            return list;
        }

        public static int[] ShuffleAndClone(int[] list)
        {
            var copy = (int[])list.Clone();
            var rng = new Random(10);

            int n = list.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = copy[k];
                copy[k] = copy[n];
                copy[n] = value;
            }

            return copy;
        }

        public static bool AreEqualArrays(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                    return false;
            }

            return true;
        }

        public static string ats(int[] a)
        {
            string buld = "[" + a[0];

            for (int i = 1; i < a.Length; i++)
            {
                buld += "," + a[i];
            }

            return buld + "]";
        }

        public static int[] OneMillion
        {
            get
            {
                return ShuffleAndClone(Generate(1000000));
            }
        }

        private static Stopwatch Timer = Stopwatch.StartNew();
        public static void StartTimer()
        {
            Timer.Restart();
        }

        public static void StopTimer()
        {
            Console.WriteLine("Time elapsed: " + Timer.Elapsed.TotalSeconds.ToString("0.00") + "s");
            Timer.Stop();
        }
    }
}