using System;
using static System.Math;
using System.Globalization;
using System.Threading;

namespace Arrays2
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
            decimal[] mass = new decimal[random.Next(25, 35)];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = random.Next(-50, 50) / 10.0M;
            }
            Console.Write("A = ");
            massiveToString(mass);
            Console.WriteLine($"Добуток елементів після мінімального {multAllAfterMin(mass)}");
            Console.WriteLine($"Сума елементів між першим відємним та другим додатнім {summMinusToPlus(mass)}");
            Console.WriteLine($"Сума елементів між першим та останнім нульовим {summZero(mass)}");
            Console.WriteLine($"Добуток елементів між мінімальним та максимальним елементом за модулем {maxAndMinMult(mass)}");
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
        public static decimal multAllAfterMin(decimal[] mass)
        {
            decimal mult = 1;
            decimal minElement = mass[0];
            for(int i = 1; i < mass.Length; i++)
            {
                if (mass[i] < minElement)
                {
                    mult = 1;
                    minElement = mass[i];
                } else
                {
                    mult *= mass[i];
                }
            }
            return mult;
        }
        public static decimal summMinusToPlus(decimal[] mass)
        {
            decimal result = 0;
            bool haveMinus = false;
            int i = 0;
            for (; i < mass.Length; i++)
            {
                if (mass[i] < 0)
                {
                    haveMinus = true;
                    break;
                }
            }
            if (!haveMinus)
            {
                return 0;
            }
            bool havePlus = false;
            for (i++; i < mass.Length; i++)
            {
                if (mass[i] > 0)
                {
                    if (havePlus)
                    {
                        return result;
                    }
                    havePlus = true;
                }
                result += mass[i];
            }
            return 0;
        }
        public static decimal summZero (decimal[] mass)
        {
            decimal summ = 0;
            decimal temp = 0;
            int i = 0;
            for (; i < mass.Length; i++)
            {
                if (mass[i] == 0)
                {
                    break;
                }
            }
            if (i < mass.Length)
            {
                for (; i < mass.Length; i++)
                {
                    if (mass[i] == 0)
                    {
                        summ += temp;
                        temp = 0;
                    }
                    else
                    {
                        temp += mass[i];
                    }
                }
            }
            return summ;
        }
        public static decimal maxAndMinMult (decimal[] mass)
        {
            decimal dob = 1;
            int[] index = new int[2];
            decimal[] elements = {Abs(mass[0]), Abs(mass[1])};
            for (int i = 1; i < mass.Length; i++)
            {
                if (Abs(mass[i]) > elements[0])
                {
                    elements[0] = Abs(mass[i]);
                    index[0] = i;
                } else if (Abs(mass[i]) < elements[1])
                {
                    elements[1] = Abs(mass[i]);
                    index[1] = i;
                }
            }
            if (index[1] > index[0])
            {
                swapNumbers(ref index[0], ref index[1]);
            }
            if (index[0] - index[1] > 0)
            {
                for (int i = index[1] + 1; i < index[0]; i++)
                {
                    dob *= mass[i];
                }
                return dob;
            }
            return 0;
        }
        private static void swapNumbers (ref int first,ref int second)
        {
            first = first + second;
            second = first - second;
            first = first - second;
        }
    }
}
