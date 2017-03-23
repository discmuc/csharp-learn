using static System.Console;

using C = System.Console;

using System;

namespace C2B.CSharp.Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = new BasicLanguage();
            var classDesign = new LearnClassDesign();
            C.ReadLine();
        }
    }

    class BasicLanguage
    {
        // static members
        private static int NUMBER1 = 2;
        private const int NUMBER2 = 3;

        // struct -> value type
        public struct Point
        {
            public int X, Y;

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public BasicLanguage()
        {
            // comment style 1
            /* comment style 2 */

            // output variable
            int testInt1 = 1;
            // implicit type
            var testInt2 = 1;
            WriteLine(testInt1);
            WriteLine(testInt2);

            // using keywords in names
            string @class = "keyword usage";
            WriteLine(@class);

            // static fields and methods
            WriteLine(NUMBER1);
            WriteLine(NUMBER2);
            WriteLine(StaticClass.getNumber());

            // explicit conversions
            int xInt = 1;
            short yShort = (short)xInt;
            WriteLine(xInt.GetType() + " " + yShort.GetType());

            // using a struct
            // Point p = null; does not work - is a value type
            Point p = new Point(1, 2);
            WriteLine(p.X + " " + p.Y);

            // silently overflow
            // checked would throw exeception
            unchecked
            {
                int overflowInt;
                overflowInt = int.MaxValue + 1;
                WriteLine(overflowInt);
            }

            // special decimal values
            WriteLine(1.0 / 0.0); // INFINITY
            WriteLine(0.0 / 0.0); // NaN

            // bool type
            bool isTrue = false;
            WriteLine(isTrue);

            // char type
            // \u unicode
            char aChar = 'C';
            WriteLine(aChar);

            // string - reference type
            string aString = "Hello world";
            WriteLine(aString);

            // verbatim string
            string anotherString = @"c:\
            test";
            WriteLine(anotherString);

            // interpolated strings
            string iString = $"{byte.MaxValue:X2}";
            WriteLine(iString);

            // arrays
            char[] vowels = new char[5];
            vowels[0] = '1';
            vowels[4] = '1';
            foreach (char c in vowels)
            {
                Console.Write(c);
            }
            WriteLine();

            // multidimensional
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 3 + j;

            // jagged
            int[][] matrix2 = new int[][]
            {
                new int[] {0,1,2},
                new int[] {3,4,5},
                new int[] {6,7,8,9}
            };

            var doubleValue = 1.0;
            WriteLine(doubleValue);

            // ref modifier
            int x = 3, y = 4;
            swap(ref x, ref y);
            WriteLine($"{x} {y}");
            // out for cases when initialization happens in method (multiple return types)

            // variable length parameters
            WriteLine(sum(1, 2, 3, 4, 5, 6, 7, 8));

            // optional params
            hello();
            hello("test");
            hello(msg: "hello");

            // null-coalescing operator
            string s1 = null;
            string s2 = s1 ?? "nothing";
            WriteLine(s2);

            // null-conditional operator
            System.Text.StringBuilder sb = null;
            string s = sb?.ToString().ToUpper() ?? "isNullValue";
            WriteLine(s);

            // nullable types - normally null cannot be assigned to an int
            int? length = sb?.ToString().Length;

            // switch
            int switchValue = 1;
            switch (switchValue)
            {
                case 1:
                    goto case 3;
                case 3:
                    goto default;
                default:
                    WriteLine("TEST");
                    break;
            }
        }

        static void swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static int sum(params int[] values)
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value;
            }
            return sum;
        }

        static void hello(string msg = "world")
        {
            WriteLine(msg);
        }
    }

    public static class StaticClass
    {
        public static int getNumber()
        {
            return 99;
        }
    }
}
