using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_and_UnitTest
{
    public class Queue<T>
    {
        private Node<T> _head, _tail;
        public Queue()
        {
            _head = null;
            _tail = null;
        }

        public void push(T data)
        {
            Node<T> new_node = new Node<T>(data);
            if(_head == null)
            {
                _head = new_node;
                _tail = new_node;
            }
            else
            {
                _tail.next = new_node;
                _tail = new_node;
            }
        }

        public void pop()
        {
            if (_head == null) throw new InvalidOperationException();
            _head = _head.next;
        }

        public T front()
        {
            if (_head == null) throw new InvalidOperationException();
            return _head.data;
        }
        public T rear()
        {
            if (_tail == null) throw new InvalidOperationException();
            return _tail.data;
        }

        public bool empty()
        {
            return _head == null;
        }
    }
}
