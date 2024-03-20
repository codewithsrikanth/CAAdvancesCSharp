using System.Collections;

namespace CollectionsExamples
{
    class Example2
    {
        static void Main(string[] args)
        {
            //ArrayList al = new ArrayList();
            ////Console.WriteLine("Initial Capacity: " + al.Capacity);
            ////Console.WriteLine("Initial Count: " + al.Count);
            //al.Add(100);al.Add(200);
            //al.Add(300);al.Add(400);
            //al.Add(500);al.Add(600);
            ////Console.WriteLine("After Capacity: " + al.Capacity);
            ////Console.WriteLine("After Count: " + al.Count);
            //Console.WriteLine("Elements of ArrayList are: ");
            //foreach (var item in al)
            //{
            //    Console.Write(item+" ");
            //}

            

            ArrayList al = new ArrayList();
            al.Add(100);al.Add(200);al.Add(300);
            al.Add(400);al.Add(500);al.Add(600);
            Console.WriteLine("Elements of Array List are: ");
            foreach(var item in al)            
                Console.Write(item + " ");            
            Console.WriteLine();
            
            al.AddRange(new int[] {601,602,603 });
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();
            
            al.Insert(2, 250);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();
            
            al.InsertRange(3, new int[] { 251, 252, 253, 254, 255 });
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();

            al.Remove(603);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();

            al.RemoveAt(4);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();

            al.RemoveRange(2,3);
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();

            al.Reverse();
            foreach (var item in al)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
