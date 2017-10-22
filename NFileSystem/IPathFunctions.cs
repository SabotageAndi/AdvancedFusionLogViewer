namespace NFileSystem
{
    internal interface IPathFunctions
    {
        string GetFileName(string path);
        string GetPathRoot(string fullPathAndFilename);
        string GetDirectoryName(string fullPath);
        string Combine(params string[] parts);
    }
}