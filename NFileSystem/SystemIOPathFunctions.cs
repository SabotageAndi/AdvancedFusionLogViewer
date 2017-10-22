using System.IO;

namespace NFileSystem
{
    internal class SystemIOPathFunctions : IPathFunctions
    {
        public string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }

        public string GetPathRoot(string fullPathAndFilename)
        {
            return Path.GetPathRoot(fullPathAndFilename);
        }

        public string GetDirectoryName(string fullPath)
        {
            return Path.GetDirectoryName(fullPath);
        }

        public string Combine(params string[] parts)
        {
            return Path.Combine(parts);
        }
    }
}