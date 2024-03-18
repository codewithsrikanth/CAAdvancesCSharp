namespace CAGenerics
{
    class Example1
    {
        //static void Display(int x)
        //{
        //    Console.WriteLine("Value of x is: "+x);
        //}
        //static void Display(string x)
        //{
        //    Console.WriteLine("Value of x is: "+x);
        //}
        //static void Display(bool x)
        //{
        //    Console.WriteLine("Value of x is: " + x);
        //}
        static void Display<T>(T x)
        {
            Console.WriteLine("Value of x is: "+x);
        }
        static void Main(string[] args)
        {
            //Example1.Display(100);
            //Example1.Display("Welcome");
            //Example1.Display(true);

            Example1.Display<int>(100);
            Example1.Display<string>("Welcome");
            Example1.Display<double>(double.MaxValue);
            Example1.Display<bool>(true);

        }
    }
}
