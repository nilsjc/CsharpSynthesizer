using System.Collections.Generic;
using ModularSynth;
using ModularSynth.Interfaces;

namespace CsharpSynthesizer
{
    public class SawOsc : SynthModule
    {
        int _SampleRate;
        double _sawIncrA = -1;
        double _sawValueA = -1;
        const string ModuleName = "Saw oscillator";

        public SawOsc(int SampleRate)
        {
            _SampleRate = SampleRate;
        }

        public string Name => ModuleName;

        public override float Signal(Dictionary<PortNames, float> input, int samplePoint)
        {
            var frequency = input[PortNames.Frequency];
            _sawIncrA = (2 * frequency) / _SampleRate;
            _sawValueA += _sawIncrA;
            if (_sawValueA >= 1)
            {
                _sawValueA = -1;
            }
            return (float)_sawValueA;
        }
    }
}
