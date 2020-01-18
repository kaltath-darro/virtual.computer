namespace VirtualComp.eu.virtualcomp.processor
{
    internal class SumBitResult
    {
        public bool Result { get; }
        public bool Carry { get; }

        public SumBitResult(bool result, bool carry)
        {
            this.Result = result;
            this.Carry = carry;
        }
    }
}
