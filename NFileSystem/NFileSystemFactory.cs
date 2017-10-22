namespace NFileSystem
{
    internal class NFileSystemFactory : INFileSystemFactory
    {
        public IPathFunctions CreatePathFunctions()
        {
            return new SystemIOPathFunctions();
        }

        public IDirectoryFunctions CreateDirectoryFunctions()
        {
            return new SystemIODirectoryFunctions();
        }
    }
}