using System;
using System.Collections.Generic;
using System.Text;

namespace NFileSystem
{
    interface IDirectoryFunctions
    {
        IEnumerable<string> EnumerateDirectories(string path);
        IEnumerable<string> EnumerateFiles(string fullPath);
    }
}
