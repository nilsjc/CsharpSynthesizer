using ModularSynth.Interfaces;
using System;
using System.Collections.Generic;

namespace ModularSynth.Modules
{
    public class SineOsc : SynthModule
    {
        private int _sampleRate;

        public string Name => "Sine oscillator";

        public SineOsc(int sampleRate)
        {
            _sampleRate = sampleRate;
        }

        public override float Signal(Dictionary<PortNames, float> input, int samplePoint)
        {
            var frequency = input[PortNames.Frequency];

            return (float)(Math.Sin((2 * Math.PI * samplePoint * frequency) / _sampleRate));
        }
    }
}
