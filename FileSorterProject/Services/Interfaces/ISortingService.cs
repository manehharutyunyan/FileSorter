using FileSorterProject.Models;

namespace FileSorterProject.Services.Interfaces
{
    interface ISortingService
    {
        /// <summary>
        /// Sorts given sortableList.
        /// </summary>
        /// <param name="sortableList"></param>
        void Sort(SortableList sortableList);
    }
}
