namespace StaticClasses
{
    static class MathUtils
    {
        public static void Add(double x, double y)
        {
            Console.WriteLine("Addition is: " + (x + y));
        }
        public static void Sub(double x, double y)
        {
            Console.WriteLine("Subtraction is: " + (x - y));
        }
        static void Main(string[] args)
        {
            MathUtils.Add(100, 200);
            MathUtils.Sub(100, 200);
        }
    }
}
