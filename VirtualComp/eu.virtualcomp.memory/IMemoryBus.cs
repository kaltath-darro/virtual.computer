using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualComp.eu.virtualcomp.memory
{
    public interface IMemoryBus
    {
        MemoryUnit Get(byte address);
        void Set(byte address, MemoryUnit memoryUnit);
        void InitCell(MemoryUnit address);
    }
}
