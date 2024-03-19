using System.Collections;

namespace CollectionsExamples
{
    class Example1
    {
        static void Main(string[] args)
        {

            
            /*Stack s = new Stack();
            s.Push(100);s.Push("Srikanth");
            s.Push(1234.56);s.Push(3.14f);
            s.Push(true);

            Console.WriteLine("Elements of Stack are: ");
            foreach(var item in s)
            {
                Console.Write(" "+item);
            }
            Console.WriteLine();
            s.Pop();
            foreach (var item in s)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();*/

            Queue q = new Queue();
            q.Enqueue(101);q.Enqueue("Srikanth");q.Enqueue(true);
            Console.WriteLine("Elements of Queue are: ");
            foreach (var item in q)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            q.Dequeue();
            Console.WriteLine("Elements of Queue are: ");
            foreach (var item in q)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            /*
             * In stack/Queue we can't insert/delete the element of our choice.
             * Because Stack is working with an algorithm i.e. LIFO, and Queue is working with an algorithm FIFO
             */

        }
    }
}
