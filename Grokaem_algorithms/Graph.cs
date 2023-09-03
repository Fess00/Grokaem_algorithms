using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Grokaem_algorithms
{
    public class GraphNode<T>
    {
        GraphNode<T>[] connections;
        T item;

        public GraphNode(int connectionSize, T item = default(T), params GraphNode<T>[] connections)
        {
            this.connections = new GraphNode<T>[connectionSize];
            this.item = item;
            for (int i = 0; i < connectionSize; i++)
            {
                this.connections[i] = connections[i];
            }
        }

        //public GraphNode()
        //{
        //    connections = null;
        //    item = default(T);
        //}

        public T GetMe()
        {
            return item;
        }

        public GraphNode<T> GetLink(int index)
        {
            if (index >= 0 && index < connections.Length)
            {
                return connections[index];
            }
            return null;
        }

        public int GetConnectionsSize()
        {
            return connections.Length;
        }
    } 

    public class Graph
    {
    }
}
