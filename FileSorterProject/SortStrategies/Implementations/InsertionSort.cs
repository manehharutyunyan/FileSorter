using FileSorterProject.SortStrategies.Interfaces;
using System;
using System.Collections.Generic;

namespace FileSorterProject.SortStrategies.Implementations
{
    class InsertionSort : ISortStrategy
    {
        /// <summary>
        /// Sorts list with InsertionSort algorithm.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public void Sort<T>(List<T> list) where T : IComparable<T>
        {
            for (int i = 0; i < list.Count - 1; ++i)
            {
                for (int j = i + 1; j > 0; --j)
                {
                    if (list[j].CompareTo(list[j - 1]) < 0)
                    {
                        T tmp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = tmp;
                    }
                }
            }
        }
    }
}
