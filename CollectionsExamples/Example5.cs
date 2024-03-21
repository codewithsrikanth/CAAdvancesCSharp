namespace CollectionsExamples
{
    class Example5
    {
        static void Main(string[] args)
        {
            Dictionary<string,object> dict = new Dictionary<string,object>();
            dict.Add("EmpID", 101);
            dict.Add("EmpName", "Srikanth");
            dict.Add("Salary", 1234.56);

            Console.WriteLine("Elements of Dictionay are: ");
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item+" => " + dict[item]);
            }
        }
    }
}
