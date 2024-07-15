namespace assignment_3
{
    public interface IEmp
    {
        public int Age { get; set; }
        public void func();

        public void func2()
        {
            Console.WriteLine("IEmp");
        }
    }
}
