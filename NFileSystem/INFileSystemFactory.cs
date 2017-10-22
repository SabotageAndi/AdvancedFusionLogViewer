namespace NFileSystem
{
    internal interface INFileSystemFactory
    {
        IPathFunctions CreatePathFunctions();
        IDirectoryFunctions CreateDirectoryFunctions();
    }
}