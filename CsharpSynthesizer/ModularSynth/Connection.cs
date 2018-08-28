using ModularSynth.Interfaces;

namespace ModularSynth
{
    public class Connection
    {
        // Module that is connected to
        public SynthModule Module { get; set; }

        // Which port of module is connected to
        public PortNames Port { get; set; }

        // Amount of signal (-1 <-> 0 <-> 1)
        public float Index { get; set; }
    }
}
