using FileSorterProject.Models;
using FileSorterProject.Services.Interfaces;
using FileSorterProject.SortStrategies.Interfaces;

namespace FileSorterProject.Services.Implementations
{
    class SortingService : ISortingService
    {
        private IEfficientSortingStrategyFinder efficientSortingStrategyFinder;
        public SortingService()
        {
            efficientSortingStrategyFinder = new EfficientSortingStrategyFinder();
        }

        public void Sort(SortableList sortableList)
        {
            ISortStrategy sortingStrategy = efficientSortingStrategyFinder.GetEfficientStrategy(sortableList);
            sortableList.SortStrategy = sortingStrategy;
            sortableList.Sort();
        }
    }
}
