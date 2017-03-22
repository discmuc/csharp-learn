using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            public int x, y;
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
