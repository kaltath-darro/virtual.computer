using System;
using VirtualComp.eu.virtualcomp.memory;

namespace VirtualComp.eu.virtualcomp.processor
{
    public class Processor
    {
        private IMemoryBus memoryBus;
        private Register R1;
        private Register R2;
        private Register A;
        private byte SP; // stack pointer
        private byte PC; //program couter
        private bool CF; //carry - nie pamiętam po co ona była

        public Processor(IMemoryBus memoryBus)
        {
            this.memoryBus = memoryBus;
            R1 = new Register(false, false, false, false, false, false, false, false);
            R2 = new Register(false, false, false, false, false, false, false, false);
            A = new Register(false, false, false, false, false, false, false, false);
        }

        public void Process()
        {
            bool isPower = true;
            while (isPower)
            {
                MemoryUnit memoryUnit =  memoryBus.Get(PC);
                //obsługa opkodów
                //Convert.ToBoolean()

            }
        }
    }
}
