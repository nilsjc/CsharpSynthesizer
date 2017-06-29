using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSynthesizer
{
    public class Synthesizer : WaveProvider32
    {
        public override int Read(float[] buffer, int offset, int sampleCount)
        {
            for (int n = 0; n < sampleCount; n++)
            {
                //Output
                buffer[n + offset] = (float)0;
            }
            return sampleCount;
        }
    }
}
