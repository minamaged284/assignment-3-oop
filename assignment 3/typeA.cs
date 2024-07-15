namespace assignment_3
{
    public class typeA
    {
        public int A { get; set; }
        public typeA(int _a)
        {
            A = _a;
        }

        public void firstFunction()
        {
            Console.WriteLine("TYPE A");
        }

        public virtual void secondFunction()
        {
            Console.WriteLine($"TYPE A = {A}");
        }
    }
}
