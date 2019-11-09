using System.Collections.Generic;

namespace FileSorterProject.Services.Interfaces
{
    interface IFileService
    {
        /// <summary>
        /// Reads text from the current stream and returns the data as a list of strings.
        /// </summary>
        /// <param name="path">The file to read from.</param>
        /// <returns></returns>
        List<string> ReadFromFile(string path);

        /// <summary>
        ///  Writes the specified string array to the file
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="arr">The string array to write to the file.</param>
        void WriteToFile(string path, List<string> list);
    }
}
