using System;
using System.Collections.Generic;
using System.Linq;

namespace NFileSystem
{
    public class Directory
    {
        private readonly Lazy<string> _nameLazy;

        public Directory(string fullPath)
        {
            FullPath = fullPath;
            _nameLazy = new Lazy<string>(() => Functions.Path.GetDirectoryName(FullPath));
        }

        public string FullPath { get; }
        public string Name => _nameLazy.Value;

        public Directory GetSubDirectory(string subDirectoryName)
        {
            return new Directory(Functions.Path.Combine(FullPath, subDirectoryName));
        }

        public IReadOnlyList<Directory> GetSubDirectories()
        {
            var dirs = Functions.Directory.EnumerateDirectories(FullPath);

            return dirs.Select(i => new Directory(i)).ToList();
        }

        public IReadOnlyList<File> GetFiles()
        {
            var files = Functions.Directory.EnumerateFiles(FullPath);


            return files.Select(i => new File(i)).ToList();
        }
    }
}