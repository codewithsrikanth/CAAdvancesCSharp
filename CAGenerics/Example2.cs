namespace CAGenerics
{
    class Arthematic<T1, T2>
    {
        public void Add(T1 a, T2 b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine("Addition is: " + (x + y));
        }
        public void Sub(T1 a, T2 b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine("Subtraction is: " + (x - y));
        }
    }
    class Example2
    {
        //var empID = 101;
        dynamic empName = "Srikanth";
        static void Main(string[] args)
        {

            var x = 10;
            //x = "Welcome";


            dynamic y = 10;
            y = "Welcome";


            Arthematic<int,int> obj1 = new Arthematic<int,int>();
            obj1.Add(100, 200);
            obj1.Sub(200, 100);

            Arthematic<double,int> obj2 = new Arthematic<double,int>();
            obj2.Add(123.45, 10);
            obj2.Sub(345.54, 20);
        }
    }
}
