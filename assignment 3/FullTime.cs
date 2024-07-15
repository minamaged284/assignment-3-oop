namespace assignment_3
{
    internal partial class Program
    {
        public class FullTime : Employee {

            public decimal Salary { get; set; }

            public new void MyFunction1()
            {
                Console.WriteLine("full time employee");
            }

            public override void Myfunction2() {
                Console.WriteLine($"employe id: {Id}, name: {Name}, age: {Age} and salary: {Salary} ");



            }
        }
    }
}
