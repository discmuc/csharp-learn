using System;

namespace C2B.CSharp.Learn
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = new BasicLanguage();
            Console.ReadLine();
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
            Console.WriteLine(testInt1);
            Console.WriteLine(testInt2);

            // using keywords in names
            string @class = "keyword usage";
            Console.WriteLine(@class);

            // static fields and methods
            Console.WriteLine(NUMBER1);
            Console.WriteLine(NUMBER2);
            Console.WriteLine(StaticClass.getNumber());

            // explicit conversions
            int xInt = 1;
            short yShort = (short)xInt;
            Console.WriteLine(xInt.GetType() + " " + yShort.GetType());

            // using a struct
            // Point p = null; does not work - is a value type
            Point p = new Point(1, 2);
            Console.WriteLine(p.X + " " + p.Y);

            // silently overflow
            // checked would throw exeception
            unchecked
            {
                int overflowInt;
                overflowInt = int.MaxValue + 1;
                Console.WriteLine(overflowInt);
            }

            // special decimal values
            Console.WriteLine(1.0 / 0.0); // INFINITY
            Console.WriteLine(0.0 / 0.0); // NaN

            // bool type
            bool isTrue = false;
            Console.WriteLine(isTrue);

            // char type
            // \u unicode
            char aChar = 'C';
            Console.WriteLine(aChar);

            // string - reference type
            string aString = "Hello world";
            Console.WriteLine(aString);

            // verbatim string
            string anotherString = @"c:\
            test";
            Console.WriteLine(anotherString);

            // interpolated strings
            string iString = $"{byte.MaxValue:X2}";
            Console.WriteLine(iString);

            // arrays
            char[] vowels = new char[5];
            vowels[0] = '1';
            vowels[4] = '1';
            foreach (char c in vowels)
            {
                Console.Write(c);
            }
            Console.WriteLine();

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
            Console.WriteLine(doubleValue);
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
