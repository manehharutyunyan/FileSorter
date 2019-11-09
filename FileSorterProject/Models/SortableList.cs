using FileSorterProject.SortStrategies.Interfaces;
using System.Collections.Generic;

namespace FileSorterProject.Models
{
    class SortableList
    {
        public ISortStrategy SortStrategy { get; set; }
        public List<string> List { get; private set; }
        public int Count => List.Count;

        public SortableList(List<string> list)
        {
            List = list;
        }

        public void Add(string item)
        {
            List.Add(item);
        }

        public void Sort()
        {
            SortStrategy.Sort(List);
        }
    }
}
