using System;
using static System.Math;
using System.Globalization;
using System.Threading;

namespace Arrays1
{
    class Program
    {
        public static Random random;
        static void Main(string[] args)
        {
            CultureInfo ci = (CultureInfo.InvariantCulture.Clone() as CultureInfo);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = ci;
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
            //
            random = new Random();
            decimal[] mass = new decimal[random.Next(10,25)];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(-50, 50) / 10.0M;
            }
            Console.Write("A = ");
            massiveToString(mass);
            //
            Console.WriteLine($"Сума негативних елементів {summNegativeElements(mass)}");
            Console.WriteLine($"Максимальний елемент елемента {maxElement(mass)}");
            Console.WriteLine($"Індекс максимального елемента {maxElementIndex(mass)}");
            Console.WriteLine($"Максимальний елемент за модулем {maxAbsElement(mass)}");
            Console.WriteLine($"Сума індексів додатних елементів {summIndex(mass)}");
            Console.WriteLine($"Кількість цілих чисел в масиві {countInt(mass)}");
            Console.ReadKey();
        }
        public static void massiveToString<T>(T[] massive)
        {
            Console.Write("{");
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write(massive[i].ToString());
                if (i != massive.Length - 1)
                {
                    Console.Write("  ");
                }
            }
            Console.Write("}\n");
        }
        public static decimal summNegativeElements(decimal[] massive)
        {
            decimal result = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] < 0)
                {
                    result += massive[i];
                }
            }
            return result;
        }
        public static decimal maxElement(decimal[] massive)
        {
            decimal maxElement = massive[0];
            for (int i = 1; i < massive.Length; i++)
            {
                if (massive[i] > maxElement)
                {
                    maxElement = massive[i];
                }
            }
            return maxElement;
        }
        public static int maxElementIndex(decimal[] massive)
        {
            int maxElementIndex = 0;
            for (int i = 1; i < massive.Length; i++)
            {
                if (massive[i] > massive[maxElementIndex])
                {
                    maxElementIndex = i;
                }
            }
            return maxElementIndex;
        }
        public static decimal maxAbsElement(decimal[] massive)
        {
            decimal maxElement = massive[0];
            for (int i = 1; i < massive.Length; i++)
            {
                if (Abs(massive[i]) > Abs(maxElement))
                {
                    maxElement = massive[i];
                }
            }
            return maxElement;
        }
        public static int summIndex(decimal[] massive)
        {
            int summ = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] > 0)
                {
                    summ += i;
                }
            }
            return summ;
        }
        public static int countInt (decimal[] massive)
        {
            int result = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 1 == 0) // воно працює!!!
                {
                    result++;
                }
            }
            return result;
        }
    }
}
