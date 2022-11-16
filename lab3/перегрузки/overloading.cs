using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class overloading
    {
        public static void Print(int x)
        {
            Console.WriteLine($"Число(int)-{x}");
        }
        public static void Print(string x)
        {
            Console.WriteLine($"Строка(string)-{x}");
        }
        public static void Print(int x, double y)
        {
            Console.WriteLine($"Число(int)-{x}, число(double)-{y}");
        }
        public static void Print(string x, string y)
        {
            Console.WriteLine($"Строка(string)-{x}, тоже трока(string)-{y}");
        }
        public static void Print(string x, string y, int z)
        {
            Console.WriteLine($"Строка(string)-{x}, тоже трока(string)-{y}, число!(int)-{z}");
        }
        public static int min(int x, int y)
        {
            if (y < x)
                return y;
            else
                return x;
        }
        public static double min(double x, double y)
        {
            if (y < x)
                return y;
            else
                return x;
        }
        public static long min(long x, long y)
        {
            if (y < x)
                return y;
            else
                return x;
        }
        public static int max(int x, int y)
        {
            if (y > x)
                return y;
            else
                return x;
        }
        public static double max(double x, double y)
        {
            if (y > x)
                return y;
            else
                return x;
        }
        public static long max(long x, long y)
        {
            if (y > x)
                return y;
            else
                return x;
        }
    }
}
