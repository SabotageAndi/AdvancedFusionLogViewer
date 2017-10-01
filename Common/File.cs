using System;

namespace Common
{
    public class File
    {
        private readonly Lazy<string> _fileNameLazy;
        private readonly Lazy<string> _path;

        public File(string fullPathAndFilename)
        {
            FullPathAndFilename = fullPathAndFilename;
            _fileNameLazy = new Lazy<string>(() => System.IO.Path.GetFileName(FullPathAndFilename));
            _path = new Lazy<string>(() => System.IO.Path.GetPathRoot(FullPathAndFilename));
        }

        public string FullPathAndFilename { get; }
        public string Filename => _fileNameLazy.Value;
        public string Path => _path.Value;
    }
}