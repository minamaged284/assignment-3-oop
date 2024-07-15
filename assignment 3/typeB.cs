namespace assignment_3
{
    public class typeB : typeA
    {
        public int B{ get; set; }
        public typeB(int _a, int _b) :base( _a)
        {
            A = _a;
            B = _b;
        }

        public new void firstFunction()
        {
            Console.WriteLine("typeB");
        }

        public override void secondFunction()
        {
            Console.WriteLine($"typeB = {B}");
        }
    }
}
