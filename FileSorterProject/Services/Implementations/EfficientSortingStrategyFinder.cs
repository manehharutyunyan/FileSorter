using FileSorterProject.Models;
using FileSorterProject.Services.Interfaces;
using FileSorterProject.SortStrategies.Implementations;
using FileSorterProject.SortStrategies.Interfaces;

namespace FileSorterProject.Services.Implementations
{
    class EfficientSortingStrategyFinder : IEfficientSortingStrategyFinder
    {
        public ISortStrategy GetEfficientStrategy(SortableList sortableList)
        {
            if (sortableList.Count < 10)
                sortableList.SortStrategy = new InsertionSort();
            else if (sortableList.Count >= 10 && sortableList.Count < 100)
                sortableList.SortStrategy = new MergeSort();
            else sortableList.SortStrategy = new QuickSort();

            return sortableList.SortStrategy;
        }
    }
}