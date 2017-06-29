using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSynthesizer
{
    interface IModule
    {
        float Signal(float amp, int SampPoint, float CV1);
        float Signal(float amp, int SampPoint, float CV1, float CV2);
        float Signal(float amp, int SampPoint, float CV1, float CV2, float CV3);
    }
}
