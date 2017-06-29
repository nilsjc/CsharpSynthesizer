using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSynthesizer
{
    interface IModule
    {
        float Signal(float amp, int SampPoint, List<float> CVs);
    }
}
