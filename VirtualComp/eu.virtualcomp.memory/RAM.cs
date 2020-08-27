using System.Collections.Generic;

namespace VirtualComp.eu.virtualcomp.memory
{
    public class RAM //255 b
    {
        private readonly IDictionary<MemoryUnit, WordUnit> memoryCells = new Dictionary<MemoryUnit, WordUnit>();

        public RAM()
        {
            
        }
        
        public void Set(MemoryUnit address, WordUnit memoryUnit)
        {
            if (memoryCells.ContainsKey(address))
            {
                memoryCells[address] = memoryUnit;
            }
            else
            {
                memoryCells.Add(address, memoryUnit);
            }
        }

        public WordUnit Get(MemoryUnit address)
        {
            if (memoryCells.ContainsKey(address))
            {
                return memoryCells[address];
            }
            throw new System.Exception("Memory address not exist");
        }

        public void Init(MemoryUnit address)
        {
            memoryCells.Add(address, WordUnit.Create());
        }

    }
}

//ram[address] = memoryUnit;
//private MemoryUnit [] ram;
//private IMemoryBus memoryBus;

//ram = new MemoryUnit[byte.MaxValue];
//for (byte i = 0; i < byte.MaxValue; i++)
//    ram[i] = new MemoryUnit(false, false, false, false, false, false, false, false);