using System;
using System.Collections.Generic;

namespace FileSorterProject.SortStrategies.Interfaces
{
    /// <summary>
    /// Interface for sorting algorithms
    /// </summary>
    interface ISortStrategy
    {
        void Sort<T>(List<T> list) where T : IComparable<T>;
    }
}
