using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokaem_algorithms
{
    internal class HashTable<T, U> // make collisions detection
    {
        U[] table;
        int capacity;
        int size;


        public HashTable(int capacity)
        {
            this.table = new U[capacity];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = default(U);
            }
            this.capacity = capacity;
            this.size = 0;
        }

        private int HashFunc(T key)
        {
            int hash = 0;
            for (int i = 0; i < key.ToString().Length; i++)
            {
                hash += (int)key.ToString()[i];
            }
            return hash % capacity;
        }

        public U this[T index]
        {
            get
            {
                int tmpIndex = HashFunc(index);
                if (table[tmpIndex] == null)
                {
                    return default(U);
                }
                return table[tmpIndex];
            }
            set
            {
                int tmpIndex = HashFunc(index);
                table[tmpIndex] = value;
                this.Size++;
            }
        }

        public int Capacity 
        { 
            get 
            {
                return this.capacity;
            } 

            private set { this.capacity = value; }
        }

        public int Size
        {
            get
            {
                return this.size;
            }

            private set { this.size = value; }
        }
    }
}
