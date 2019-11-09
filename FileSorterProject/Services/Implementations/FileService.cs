using FileSorterProject.Services.Interfaces;
using System.Collections.Generic;

namespace FileSorterProject.Services.Implementations
{
    public class FileService : IFileService
    {
        public List<string> ReadFromFile(string path)
        {
            List<string> reader = new List<string>();

            using (System.IO.StreamReader file = new System.IO.StreamReader(path))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    reader.Add(line);
                }
            }

            return reader;
        }

        public void WriteToFile(string path, List<string> list)
        {
            System.IO.File.WriteAllLines(path, list);
        }
    }
}
