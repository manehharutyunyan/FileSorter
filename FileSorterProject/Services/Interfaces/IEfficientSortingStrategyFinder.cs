using FileSorterProject.Models;
using FileSorterProject.SortStrategies.Interfaces;

namespace FileSorterProject.Services.Interfaces
{
    interface IEfficientSortingStrategyFinder
    {
        /// <summary>
        /// Criteria for choosing efficient sorting algorithm for text files.
        /// </summary>
        /// <param name="sortableList"></param>
        /// <returns></returns>
        ISortStrategy GetEfficientStrategy(SortableList list);
    }
}
