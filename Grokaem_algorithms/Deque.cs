using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokaem_algorithms
{
    public class Deque<T>
    {
        Node<T> first;
        Node<T> last;
        int size;

        public Deque() 
        {
            size = 0;
            first = null;
            last = first;
        }

        public Node<T> Get()
        {
            Node<T> tmp = first;
            if (size == 0)
            {
                return tmp;
            }
            else if (size == 1)
            {
                first = null;
                last = first;
                size--;
                return tmp;
            }
            else
            {
                first = this[1];
                size--;
                return tmp;
            }
        }

        public void Add(T item)
        {
            if (size == 0)
            {
                first = new Node<T>(item);
                last = first;
                size++;
            }
            else if (size == 1)
            {
                Node<T> tmp = new Node<T>(item);
                first.Next = tmp;
                last = tmp;
                size++;
            }
            else if (size > 1)
            {
                Node<T> tmp = new Node<T>(item);
                last.Next = tmp;
                last = tmp;
                size++;
            }
        }

        public bool IsNull()
        {
            if (size == 0)
            {
                return true;
            }
            return false;
        }

        private Node<T> this[int index]
        {
            get
            {
                if (index < size)
                {
                    Node<T> tmp = first;
                    if (index == 0)
                    {
                        return tmp;
                    }
                    for (int i = 1; i <= index; i++)
                    {
                        tmp = tmp.Next;
                    }
                    return tmp;
                }
                else
                {
                    return null;
                }
            }

            set { this[index] = value; }
        }
    }
}
