namespace VirtualComp.eu.virtualcomp.memory
{
    public class WordUnit
    {
        public MemoryUnit Byte1 { get; private set; }
        public MemoryUnit Byte2 { get; private set; }
        public MemoryUnit Byte3 { get; private set; }
        public MemoryUnit Byte4 { get; private set; }

        private WordUnit()
        {
            Byte1 = MemoryUnit.Init();
            Byte2 = MemoryUnit.Init();
            Byte3 = MemoryUnit.Init();
            Byte4 = MemoryUnit.Init();
        }

        public static WordUnit Create()
        {
            return new WordUnit();
        }

        public void Set(MemoryUnit byte1, MemoryUnit byte2, MemoryUnit byte3, MemoryUnit byte4)
        {
            this.Byte1 = byte1;
            this.Byte2 = byte2;
            this.Byte3 = byte3;
            this.Byte4 = byte4;
        }
    }
}
