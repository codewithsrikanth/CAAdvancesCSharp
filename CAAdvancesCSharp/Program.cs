namespace SealedClassesAndMethods
{
    class Employee
    {
        public void Demo()
        {
            Console.WriteLine("Welcome");
        }
        public virtual void CalSalary(int hrs)
        {
            Console.WriteLine("Employee Salary is: "+(hrs*2000));
        }
    }
    class Trainer:Employee
    {
        public new void Demo()
        {
            Console.WriteLine("Hello");
        }
        public sealed override void CalSalary(int hrs)
        {            
            Console.WriteLine("Trainer Salary is: "+(hrs * 3000));
        }
    }
    sealed class TechnicalTrainer:Trainer
    {
        //public override void CalSalary(int hrs)
        //{
        //    Console.WriteLine("Technical Trainer Salary: " + (hrs * 4000));
        //}
        //public virtual void Demo1() { }
        public void Sample()
        {
            Console.WriteLine("This is sample function");
        }
        public new void Demo()
        {
            Console.WriteLine("Hi");
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            TechnicalTrainer obj = new TechnicalTrainer();
            obj.Sample();
            obj.CalSalary(8);
            obj.Demo();
        }
    }
}
