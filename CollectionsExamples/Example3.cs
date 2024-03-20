using System.Collections;

namespace CollectionsExamples
{
    class Example3
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("EmpID", 101);ht.Add("EmpName", "Srikanth");
            ht.Add("Salary", 1234.56);ht.Add("Subject", "C#.Net");

            Console.WriteLine("EmpID".GetHashCode());

            Console.WriteLine("Elements of Hashtable are: ");
            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }

            ht.Remove("Salary");
            Console.WriteLine("Elements of Hashtable are: ");
            foreach (var item in ht)
            {
                Console.WriteLine(item);
            }

        }
    }
}
