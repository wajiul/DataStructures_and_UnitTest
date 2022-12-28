using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_UnitTest
{
    class A<T>
    {
        public T N { get; set; }
        public void Show()
        {
            Console.WriteLine("val = " + N);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stk = new Stack<int>();

            stk.push(10);
            stk.push(3);
            Console.WriteLine("e = " + stk.top());
            stk.pop();
            Console.WriteLine("e = " + stk.top());

            stk.push(1);
            stk.push(5);

            while(!stk.empty())
            {
                Console.WriteLine(stk.top());
                stk.pop();
            }
            Console.ReadLine();
        }
    }
}
