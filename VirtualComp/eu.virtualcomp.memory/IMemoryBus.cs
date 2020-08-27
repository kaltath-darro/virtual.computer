namespace VirtualComp.eu.virtualcomp.memory
{
    public interface IMemoryBus<TAddress, TValue>
    {
        TValue Get(TAddress address);
        void Set(TAddress address, TValue memoryUnit);
        void InitCell(TAddress address);
    }
}
