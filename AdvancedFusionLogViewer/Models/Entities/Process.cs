using System.Collections.Generic;

namespace AdvancedFusionLogViewer.Models.Entities
{
    public class Process
    {
        public Process(string name, LogCategory logCategory, IReadOnlyList<Assembly> assemblies)
        {
            Name = name;
            LogCategory = logCategory;
            Assemblies = assemblies;
        }
        public string Name { get;  }
        public LogCategory LogCategory { get;  }

        public IReadOnlyList<Assembly> Assemblies { get;  }
    }
}