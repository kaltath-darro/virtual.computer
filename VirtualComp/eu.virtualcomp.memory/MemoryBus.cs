namespace VirtualComp.eu.virtualcomp.memory
{
    public class MemoryBus : IMemoryBus<MemoryUnit, WordUnit>
    {
        private RAM ram;

        public MemoryBus(RAM ram)
        {
            this.ram = ram;
        }

        public WordUnit Get(MemoryUnit address)
        {
            return ram.Get(address);
        }

        public void InitCell(MemoryUnit address)
        {
            ram.Init(address);
        }

        public void Set(MemoryUnit address, WordUnit memoryUnit)
        {
            ram.Set(address, memoryUnit);
        }
    }
}
