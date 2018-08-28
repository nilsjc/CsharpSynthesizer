using System.Collections.Generic;

namespace ModularSynth.Interfaces
{
    public abstract class SynthModule
    {
        string Name { get; }

        public abstract float Signal(Dictionary<PortNames, float> input, int samplePoint);
    }
}
