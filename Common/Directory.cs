using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Common
{
    public class Directory
    {
        private readonly Lazy<string> _nameLazy;

        public Directory(string fullPath)
        {
            FullPath = fullPath;
            _nameLazy = new Lazy<string>(() => Path.GetDirectoryName(FullPath));
        }

        public string FullPath { get; }
        public string Name => _nameLazy.Value;

        public Directory SubDirectory(string subDirectoryName)
        {
            return new Directory(Path.Combine(FullPath, subDirectoryName));
        }

        public IReadOnlyList<Directory> GetSubDirectories()
        {
            var dirs = System.IO.Directory.EnumerateDirectories(FullPath);

            return dirs.Select(i => new Directory(i)).ToList();
        }
    }
}