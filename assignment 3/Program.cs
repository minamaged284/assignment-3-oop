using System.ComponentModel;

namespace assignment_3
{
    internal partial class Program
    {
        //instead of using two functions one for fulltime and one for part time i will use only onr that takes empluee and bind the others
        public static void EmpInfo(Employee emp)
        {
            emp.Myfunction1();
            emp.Myfunction2();
        }
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
            //Console.WriteLine(sum(1,2,3));

            #region inheritence and overriding
            //typeA typeA = new typeA(4);
            //typeB typeB = new typeB(4, 5);
            //typeA.firstFunction();
            //typeA.secondFunction();
            //typeB.firstFunction();
            //typeB.secondFunction();
            #endregion

            #region binding

            typeA typeB2 = new typeB(3,4);
            typeB2.A = 10;
            //typeB2.B = 20; invalid
            typeB2.firstFunction(); //typeA static binding (new)
            typeB2.secondFunction();//TypeB dynamic binding (override)


            typeB tupeA2 = (typeB) new typeA(3); //unsafe casting

            #region employee example

            Employee fullTime = new FullTime()
            {
                Id = 1,
                Name = "mina",
                Age = 27,
                Salary = 2700,


            };

            Employee partTime = new PartTime()
            {

                Id = 2,
                Name = "beshoy",
                Age = 24,
                HourRate = 25,
            };

            EmpInfo(fullTime);
            EmpInfo(partTime);

            #endregion


            #endregion
            #region interface

            IEmp emp = new Emp();
            emp.func2(); // from the interface
            emp.func();  // from the object
            emp.Age = 30;
            #endregion



        }
    }
}
