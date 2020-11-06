using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Mult(int x, int y)
        {
            return x * y;
        }

        static int Sub(int x, int y)
        {
            return x - y;
        }

        delegate int MathFunc(int x, int y);    // function pointer, a type that can be assigned any function that returns an int and takes in two ints

        //delegate void ActionRef(int x, int y); // you can define your own ACtion ref https://stackoverflow.com/questions/1707310/is-it-possible-to-use-ref-types-in-c-sharp-built-in-action-delegate/7910081

        delegate void ActionRef(ref int x);
        static void Main(string[] args)
        {
            var nums = new List<int>{ 1, 2, 3, 4 };

            //var funcs = new List<> { Add, Mult, Sub };  // what do we put inside the <>?

            //MathFunc addFunc = Add; // assign add to MathFunc

            //Console.WriteLine(Add(5,6));
            //Console.WriteLine(addFunc(2,3));

            //MathFunc divideFunc = (int x, int y) => x / y;

            //Console.WriteLine(divideFunc(12,6));

            // Actions return type is void, input is ranging from 0 params to 16 params
            int x = 5;
            ActionRef foo = (ref int val) => 
            {
                val += 55;
                Console.WriteLine(val); 
            };

            foo(ref x);

            Console.WriteLine(x);

        }
    }
}
