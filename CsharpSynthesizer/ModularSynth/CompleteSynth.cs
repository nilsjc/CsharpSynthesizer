using System.Collections.Generic;

namespace ModularSynth
{
    public class CompleteSynth
    {
        public string Name { get; set; }
        public List<ModuleInstance> Modules { get; set; }

        public void Add(ModuleInstance module)
        {
            Modules.Add(module);
        }

        public void Remove(ModuleInstance module)
        {
            Modules.Remove(module);
        }
    }
}
