using FileSorterProject.SortStrategies.Interfaces;
using System;
using System.Collections.Generic;

namespace FileSorterProject.SortStrategies.Implementations
{
    class MergeSort : ISortStrategy
    {
        /// <summary>
        /// Sorts list with M  MergeSort algorithm.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public void Sort<T>(List<T> list) where T : IComparable<T>
        {
            MergeSorting<T>(list, 0, list.Count - 1);
        }
        private void MergeSorting<T>(List<T> list, int p, int q) where T : IComparable<T>
        {
            if (p < q)
            {
                int r = (q + p) / 2;
                MergeSorting(list, p, r);
                MergeSorting(list, r + 1, q);
                Merge(list, p, r, q);
            }
        }
        private void Merge<T>(List<T> list, int p, int r, int q) where T : IComparable<T>
        {
            int curr = p;
            int n1 = r - p + 1;
            int n2 = q - r;
            T[] a1 = new T[n1];
            T[] a2 = new T[n2];
            int i = 0, j = 0;

            for (i = 0; i < n1; i++)
            {
                a1[i] = list[p + i];
            }
            for (i = 0; i < n2; i++)
            {
                a2[i] = list[r + i + 1];
            }

            i = 0; j = 0;
            while (i < n1 && j < n2)
            {
                if (a1[i].CompareTo(a2[j]) < 0)
                {
                    list[curr] = a1[i];
                    ++i;
                    ++curr;
                }
                else
                {
                    list[curr] = a2[j];
                    ++j;
                    ++curr;
                }
            }
            while (i < n1)
            {
                list[curr] = a1[i];
                ++i;
                ++curr;
            }
            while (j < n2)
            {
                list[curr] = a2[j];
                ++j;
                ++curr;
            }
        }
    }
}
