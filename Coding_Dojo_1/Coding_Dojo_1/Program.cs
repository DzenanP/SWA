using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Dojo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            String();
            Int();
            Object();

            Console.ReadLine();

        }

        static void Int()
        {
            Stack<int> test = new Stack<int>();

            test.Push(11);
            test.Push(12);
            test.Push(13);

            Console.WriteLine("{0} entfernt", test.Pop());
            Console.WriteLine("{0} entfernt", test.Pop());
            Console.WriteLine(":{0}", test.Peek());
            Console.WriteLine("{0} entfernt", test.Pop());
        }

        static void String()
        {
            Stack<string> test = new Stack<String>();

            test.Push("A");
            test.Push("B");
            test.Push("C");

            Console.WriteLine("{0} entfenrt", test.Pop());
            Console.WriteLine(": {0}", test.Peek());
            Console.WriteLine("{0} entfernt", test.Pop());
            Console.WriteLine("{0} entfernt", test.Pop());
        }

        static void Object()
        {
            Stack<Person> test = new Stack<Person>();

            test.Push(new Person(22, "Martin"));
            test.Push(new Person(25, "Josef"));
            test.Push(new Person(24, "Peter"));
            test.Push(new Person(20, "Max"));

            Console.WriteLine("{0} wurde entfernt", test.Pop());
            Console.WriteLine(":{0}", test.Peek());
            Console.WriteLine("{0} wurde entfernt", test.Pop());
            Console.WriteLine(":{0}", test.Peek());
            Console.WriteLine("{0} wurde entfernt", test.Pop());
            Console.WriteLine(":{0}", test.Peek());
            Console.WriteLine("{0} wurde entfernt", test.Pop());
            Console.WriteLine(":{0}", test.Peek());

        }
    }
}
