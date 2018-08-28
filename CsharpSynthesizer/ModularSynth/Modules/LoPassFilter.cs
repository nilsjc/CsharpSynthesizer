using ModularSynth;
using ModularSynth.Interfaces;
using System.Collections.Generic;

namespace CsharpSynthesizer.SynthModules
{
    public class LoPassFilter : SynthModule
    {
        int _sampleRate;
        float _k;
        float _r;
        float _p;
        float _x0;
        float _oldX0;
        float _oldY1;
        float _oldY2;
        float _oldY3;
        float _y1;
        float _y2;
        float _y3;
        float _y4;

        const string ModuleName = "Moog LoPass filter";

        public LoPassFilter(int sampleRate)
        {
            _sampleRate = sampleRate;
        }

        public string Name => ModuleName;
        
        public override float Signal(Dictionary<PortNames, float> input, int samplePoint)
        {
            var frequency = input[PortNames.Frequency];
            var q = input[PortNames.Q];
            var filterInput = input[PortNames.AudioIn];

            //Moog filter simulation
            //Frequency and Q parameters
            _k = frequency;
            _k = _k / 10;
            _r = q;
            _p = (_k + 1) * (float)0.6;

            //--Inverted feed back for corner peaking
            _x0 = (float)(q * filterInput) - _r * _y4;

            //Four cascaded onepole filters (bilinear transform)
            _y1 = _x0 * _p + _oldX0 * _p - _k * _y1;
            _y2 = _y1 * _p + _oldY1 * _p - _k * _y2;
            _y3 = _y2 * _p + _oldY2 * _p - _k * _y3;
            _y4 = _y3 * _p + _oldY3 * _p - _k * _y4;

            //Clipper band limited sigmoid
            _y4 = _y4 - (_y4 * _y4 * _y4) / 6;

            _oldX0 = _x0;
            _oldY1 = _y1;
            _oldY2 = _y2;
            _oldY3 = _y3;

            return _y4;
        }
    }
}
