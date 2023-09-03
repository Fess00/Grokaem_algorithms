using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokaem_algorithms
{
    internal static class GrokaemAlgo
    {
        public static int BinarySearch(int[] array, int element)
        {
            int high = array.Length - 1;
            int low = 0;

            while (high > low)
            {
                int mid = (high + low) / 2;
                if (element < array[mid])
                {
                    high = mid - 1;
                }
                else if (element > array[mid])
                {
                    low = mid + 1;
                }
                else
                    return mid;
            }

            return -1;
        }

        public static void SelectionSort(int[] array)
        {
            int swap;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }
        }

        public static int RecursiveSum(int[] array, int index = 0)
        {
            if (index == array.Length - 1)
            {
                return array[index];
            }
            else
            {
                return RecursiveSum(array, index + 1) + array[index];
            }
        }

        public static void QSort(int[] array)
        {
            QSort(array, 0, array.Length - 1);
        }

        public static void QSort(int[] array, int left, int right)
        {
            int tmpLeft = left;
            int tmpRight = right;
            int pivot = array[right];
            int swap;

            while (tmpRight >= tmpLeft)
            {
                while (array[tmpRight] > pivot)
                {
                    tmpRight--;
                }

                while (array[tmpLeft] < pivot)
                {
                    tmpLeft++;
                }

                if (tmpLeft <= tmpRight)
                {
                    swap = array[tmpLeft];
                    array[tmpLeft] = array[tmpRight];
                    array[tmpRight] = swap;
                    tmpRight--;
                    tmpLeft++;
                }
            }

            if (left < tmpRight)
            {
                QSort(array, left, tmpRight);
            }
            if (right > tmpLeft)
            {
                QSort(array, tmpLeft, right);
            }
        }

        public static bool BFSearch(GraphNode<int> node, int item)
        {
            Deque<GraphNode<int>> q = new Deque<GraphNode<int>>();
            q.Add(node);
            ArrayList searched = new ArrayList();

            while (q.IsNull() != true)
            {
                GraphNode<int> cur = q.Get().Item;
                if (searched.Contains(cur) == false)
                {
                    if (cur.GetMe() == item)
                    {
                        return true;
                    }
                    else
                    {
                        for (int i = 0; i < cur.GetConnectionsSize(); i++)
                        {
                            q.Add(cur.GetLink(i));
                        }
                        searched.Add(cur);
                    }
                }
            }
            return false;
        }
    }
}
