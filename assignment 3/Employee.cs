namespace assignment_3
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public void Myfunction1()
        {
            Console.WriteLine("Employee");
        }

        public virtual void Myfunction2() {
            Console.WriteLine($"employe id: {Id}, name: {Name}, age: {Age} ");

        }


    }
}
