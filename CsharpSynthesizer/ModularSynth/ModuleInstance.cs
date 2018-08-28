using ModularSynth.Interfaces;
using System.Collections.Generic;

namespace ModularSynth
{
    public class ModuleInstance
    {
        public SynthModule Module { get; set; }

        // List of modules + ports that this module is connected to
        public List<Connection> Connnections { get; set; }
    }
}
