using System.Collections;

namespace CollectionsExamples
{
    class Example2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            //Console.WriteLine("Initial Capacity: " + al.Capacity);
            //Console.WriteLine("Initial Count: " + al.Count);
            al.Add(100);al.Add(200);
            al.Add(300);al.Add(400);
            al.Add(500);al.Add(600);
            //Console.WriteLine("After Capacity: " + al.Capacity);
            //Console.WriteLine("After Count: " + al.Count);
            Console.WriteLine("Elements of ArrayList are: ");
            foreach (var item in al)
            {
                Console.Write(item+" ");
            }

        }
    }
}
