using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSynthesizer
{
    public class ModuleSawOsc
    {
        int _SampleRate;

        public ModuleSawOsc(int SampleRate)
        {
            _SampleRate = SampleRate;
        }

        public float Signal(float amp, int SampPoint, float CV1)
        {
            double sawIncrA = -1;
            double sawValueA = -1;
            sawIncrA = (2*CV1)/_SampleRate;
            sawValueA += sawIncrA;
            if (sawValueA >= 1)
            {
                sawValueA = -1;
            }
            return (float)sawValueA;
        }
    }
}
