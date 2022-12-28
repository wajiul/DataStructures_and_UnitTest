using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_UnitTest
{
    public class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node (T _data)
        {
            data = _data;
            next = null;
        }
        public Node(T _data, Node<T> _next)
        {
            data = _data;
            next = _next;
        }

    }
}
