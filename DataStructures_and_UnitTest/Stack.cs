using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_UnitTest
{
    public class Stack<T>
    {
        private Node<T> head;
        public Stack()
        {
            head = null;
        }
        public void push(T _data)
        {
            var new_node = new Node<T>(_data, head);
            head = new_node;
        }

        public void pop()
        {
            if (head == null) throw new InvalidOperationException();
            head = head.next;
        }
        public T top()
        {
            if (head == null) throw new InvalidOperationException();
            return head.data;
        }
        public bool empty()
        {
            return head == null;
        }

    }
}
