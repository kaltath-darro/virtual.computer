namespace VirtualComp.eu.virtualcomp.memory
{
    public class MemoryBus : IMemoryBus
    {
        private RAM ram;

        public MemoryBus(RAM ram)
        {
            this.ram = ram;
        }

        public MemoryUnit Get(byte address)
        {
            return ram.Get(address);
        }

        public void InitCell(MemoryUnit address)
        {
            ram.Init(address);
        }

        public void Set(byte address, MemoryUnit memoryUnit)
        {
            ram.Set(address, memoryUnit);
        }
    }
}
