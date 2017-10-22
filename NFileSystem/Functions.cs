namespace NFileSystem
{
    internal class Functions
    {
        private static INFileSystemFactory _inFileSystemFactory = new NFileSystemFactory();

        public static IPathFunctions Path => _inFileSystemFactory.CreatePathFunctions();
        public static IDirectoryFunctions Directory => _inFileSystemFactory.CreateDirectoryFunctions();

        public static void SetFactory(INFileSystemFactory inFileSystemFactory)
        {
            _inFileSystemFactory = inFileSystemFactory;
        }
    }
}