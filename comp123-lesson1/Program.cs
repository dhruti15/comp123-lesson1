using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp123_lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the hello wolrld to console method
            HelloWorldToConsole();
        }
        /**
        *#description this is my hello world method
        *#returns {string} hello world string
        */
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello, world!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString;
        }
    }
}
