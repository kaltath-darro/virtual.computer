using VirtualComp.eu.virtualcomp.memory;

namespace VirtualComp.eu.virtualcomp.processor
{
    public class Register 
    {
        public MemoryUnit State { get; private set; }

        public Register(bool a, bool b, bool c, bool d, bool e, bool f, bool g, bool h)
        {
            State = new MemoryUnit(a, b, c, d, e, f, g, h);
        }
    }
}
