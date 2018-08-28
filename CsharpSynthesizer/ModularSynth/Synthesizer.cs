using ModularSynth;
using System.Collections.Generic;

namespace CsharpSynthesizer
{
    public class Synthesizer : WaveProvider32
    {
        ModuleInstance[] _moduleInstances;

        public void Create(List<ModuleInstance> modules)
        {
            _moduleInstances = new ModuleInstance[modules.Count];
        }

        public override int Read(float[] buffer, int offset, int sampleCount)
        {
            for (int n = 0; n < sampleCount; n++)
            {
                //Calculate all modules and use the result
                for(int i = 0; i < _moduleInstances.Length; i++)
                {
                    _moduleInstances[i].Module.Signal(null, sampleCount);
                }

                //Output
                buffer[n + offset] = (float)0;
            }
            return sampleCount;
        }
    }
}
