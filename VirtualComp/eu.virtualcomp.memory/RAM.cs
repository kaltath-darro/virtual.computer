﻿namespace VirtualComp.eu.virtualcomp.memory
{
    public class RAM //255 b
    {
        private MemoryUnit [] ram;
        private IMemoryBus memoryBus;

        public RAM()
        {
            ram = new MemoryUnit[byte.MaxValue];
            for (byte i = 0; i < byte.MaxValue; i++)
                ram[i] = new MemoryUnit(false, false, false, false, false, false, false, false);
        }
        
        public void Set(byte address, MemoryUnit memoryUnit)
        {
            ram[address] = memoryUnit;
        }

        public MemoryUnit Get(byte address)
        {
            return ram[address];
        }

    }
}
