using FileSorterProject.SortStrategies.Interfaces;
using System;
using System.Collections.Generic;

namespace FileSorterProject.SortStrategies.Implementations
{
    class QuickSort : ISortStrategy
    {
        /// <summary>
        /// Sorts list with QuickSort algorithm.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">list</param>
        public void Sort<T>(List<T> list) where T : IComparable<T>
        {
            QuickSorting<T>(list, 0, list.Count - 1);
        }
        private void QuickSorting<T>(List<T> list, int p, int q) where T : IComparable<T>
        {
            if (p < q)
            {
                int r = Partition(list, p, q);
                QuickSorting(list, p, r);
                QuickSorting(list, r + 1, q);
            }
        }
        private static int Partition<T>(List<T> list, int p, int q) where T : IComparable<T>
        {
            int i = p - 1, j = q + 1;
            T x = list[p];
            while (true)
            {
                do
                {
                    ++i;
                } while (list[i].CompareTo(x) < 0);

                do
                {
                    --j;
                } while (list[j].CompareTo(x) > 0);

                if (i < j)
                {
                    T c = list[i];
                    list[i] = list[j];
                    list[j] = c;
                }

                else
                    return j;
            }
        }
    }
}
