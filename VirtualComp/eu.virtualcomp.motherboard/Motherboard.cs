using VirtualComp.eu.virtualcomp.memory;
using VirtualComp.eu.virtualcomp.processor;

namespace VirtualComp.eu.virtualcomp.motherboard
{
    public class Motherboard
    {
        private RAM ram;
        private IMemoryBus<MemoryUnit, WordUnit> memoryBus;
        private Processor processor;

        public Motherboard()
        {
            ram = new RAM();
            memoryBus = new MemoryBus(ram);
            processor = new Processor(memoryBus);
        }


    }
}
