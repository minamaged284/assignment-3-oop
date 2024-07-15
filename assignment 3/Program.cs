using System.ComponentModel;

namespace assignment_3
{
    internal class Program
    {
        #region method overloading

        /*
         when more than a function has the same name but differs in parameters(type,number and order)
         */
        public static int sum(int a, int b)
        {
            return a + b;
        }

        public static int sum(int a, int b, int c)
        {
            return a + b;
        }

        public static int sum(int a, int b, int c , int d)
        {
            return a + b;
        }

        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
