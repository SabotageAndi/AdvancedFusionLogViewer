using System.Collections.Generic;
using System.Linq;
using AdvancedFusionLogViewer.Models.Entities;
using NFileSystem;


namespace AdvancedFusionLogViewer.Models.Logic
{
    internal class LogDirectoryWalker
    {
        public IReadOnlyList<Process> Load(Directory logDirectory)
        {
            var defaultProcess = LoadLogCategory(LogCategory.Default, logDirectory);
            var nativeImageProcess = LoadLogCategory(LogCategory.NativeImages, logDirectory);


            return defaultProcess.Union(nativeImageProcess).ToList();
        }

        private IReadOnlyList<Process> LoadLogCategory(LogCategory logCategory, Directory logDirectory)
        {
            var rootDirectory = logDirectory.GetSubDirectory(logCategory.ToString());

            var subDirectories = rootDirectory.GetSubDirectories();

            return subDirectories.Select(i => LoadProcess(i, logCategory)).ToList();
        }

        private Process LoadProcess(Directory processDirectory, LogCategory logCategory)
        {
            var process = new Process(processDirectory.Name, logCategory, null);

            return process;
        }
    }
}