using static System.Console;

using System;
using System.Text;

namespace C2B.CSharp.Learn
{
    public class LearnClassDesign
    {
        public LearnClassDesign()
        {
            WriteLine("inside LearnClassDesign");
            var test1 = new TestClass1("Test");

            // object initializer
            var test2 = new TestClass2 { S1 = "TEST1", S2 = "TEST2" };
            test2.print();
            var test3 = new TestClass3();
        }
    }

    public class TestClass1
    {
        // assignment of multiple fields
        readonly int i1 = 1, i2 = 2;

        readonly int i3;

        // defining a constant
        public const double PI = 3.1415;

        // static constructor
        static TestClass1()
        {
            WriteLine("static constructor called");
        }

        // finalizer
        ~TestClass1()
        {
            WriteLine("Finalize TestClass1");
        }

        public TestClass1()
        {
            // readonly initialization in constructor
            i3 = 3;

            Foo2("" + Foo1(2));

            // overloading
            Foo(1);
            Foo(1.0);

            // this reference
            WriteLine(this.GetType());

            // automatic properties
            OneProperty = 1;
            WriteLine(OneProperty);
            WriteLine(SecondProperty);

            // indexed class
            var indexedClass = new TestIndexer();
            WriteLine(indexedClass[0]);

            // using a constant
            WriteLine(PI);

            // nameof
            WriteLine(nameof(indexedClass));
        }

        // constructor overloading
        public TestClass1(string s) : this() // overloaded constructor is called first
        {
            WriteLine(s);
        }

        // expression bodied methods
        int Foo1(int x) => x * 2;
        void Foo2(string s) => WriteLine(s);

        // method overloading
        int Foo(int i) => i * 2;
        double Foo(double d) => d * 2;

        // properties
        public int OneProperty
        {
            get;
            set;
        }

        // expression-bodied property
        int SecondProperty => OneProperty + 1;

    }

    public class TestClass2
    {
        public string S1;
        public string S2;

        public void print()
        {
            WriteLine(S1 + " " + S2);
        }
    }

    // indexer class
    public class TestIndexer
    {
        string[] words = "This is a test.".Split();

        public string this[int wordNum]
        {
            get { return words[wordNum]; }
            set { words[wordNum] = value; }
        }
    }

    public partial class TestClass3
    {
        partial void testMethod();
    }

    public partial class TestClass3
    {

        public TestClass3()
        {
            testMethod();
        }

        partial void testMethod()
        {
            WriteLine("Partial");
        }
    }
}
