using System.Collections.Generic;

namespace NFileSystem
{
    class SystemIODirectoryFunctions : IDirectoryFunctions
    {
        public IEnumerable<string> EnumerateDirectories(string path)
        {
            return System.IO.Directory.EnumerateDirectories(path);
        }

        public IEnumerable<string> EnumerateFiles(string fullPath)
        {
            return System.IO.Directory.EnumerateFiles(fullPath);
        }
    }
}