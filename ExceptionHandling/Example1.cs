namespace ExceptionHandling
{
    class Example1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter two numbers: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 == 0)
                {
                    Console.WriteLine("Second number can't be zero");
                }
                else
                {
                    int res = num1 / num2;
                    Console.WriteLine("Result is: " + res);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occured");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            //catch
            //{
            //    Console.WriteLine("Error Occured");
            //}
            finally
            {
                Console.WriteLine("This is finally block - it will execute always");
            }                    
        }
    }
}
