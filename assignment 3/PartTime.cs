namespace assignment_3
{
    public class PartTime : Employee
    {
        public int HourRate { get; set; }

        public new void MyFunction1()
        {
            Console.WriteLine("part time employee");
        }

        public override void Myfunction2()
        {
            Console.WriteLine($"employe id: {Id}, name: {Name}, age: {Age} and salary: {HourRate} ");



        }

    }
}
