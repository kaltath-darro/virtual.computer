using VirtualComp.eu.virtualcomp.memory;

namespace VirtualComp.eu.virtualcomp.processor
{
    public interface IInstruction
    {
        void Invoke(MemoryUnit arg1, MemoryUnit arg2);
    }
}
