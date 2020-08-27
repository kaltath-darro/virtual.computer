using VirtualComp.eu.virtualcomp.memory;

namespace VirtualComp.eu.virtualcomp.processor
{
    public class Processor
    {
        private const bool b0 = false;
        private const bool b1 = true;
        private IMemoryBus<MemoryUnit, WordUnit> memoryBus;
        private Register R1;
        private Register R2;
        private Register A;
        private byte SP; // stack pointer
        private MemoryUnit PC;
        private bool CF; //carry - nie pamiętam po co ona była
        private IInstruction instruction;
        private readonly AdditionModule additionModule;
        private readonly MemoryUnit one = new MemoryUnit(b0, b0, b0, b0, b0, b0, b0, b1);

        public Processor(IMemoryBus<MemoryUnit, WordUnit> memoryBus)
        {
            this.memoryBus = memoryBus;
            this.additionModule = new AdditionModule();
            AddressingMemory();
            PC = MemoryUnit.Init();
            A = new Register(false, false, false, false, false, false, false, false);
            R1 = new Register(false, false, false, false, false, false, false, false);
            R2 = new Register(false, false, false, false, false, false, false, false);
        }

        public void Process()
        {
            bool isPower = true;
            while (isPower)
            {
                WordUnit line = memoryBus.Get(PC);
                //instruction = new MovInstruction();
                
                instruction.Invoke(line.Byte2, line.Byte3);

                //obsługa opkodów
                //Convert.ToBoolean()

                PC = additionModule.Add(PC, one);

                if (PC.IsMax())
                    isPower = false;
            }
        }

        private void AddressingMemory()
        {
            MemoryUnit address = MemoryUnit.Init();

            while (!address.IsMax())
            {
                address = additionModule.Add(address, one);
                memoryBus.InitCell(address);
            }
        }
    }
}
//private byte PC; //program couter