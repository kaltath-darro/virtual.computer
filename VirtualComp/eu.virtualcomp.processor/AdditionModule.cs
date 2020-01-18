using VirtualComp.eu.virtualcomp.memory;

namespace VirtualComp.eu.virtualcomp.processor
{
    public class AdditionModule
    {

        public MemoryUnit Add(MemoryUnit a, MemoryUnit b)
        {
            SumBitResult hbit = SumBit(a.getH(), b.getH(), false);
            SumBitResult gbit = SumBit(a.getG(), b.getG(), hbit.Carry);
            SumBitResult fbit = SumBit(a.getF(), b.getF(), gbit.Carry);
            SumBitResult ebit = SumBit(a.getE(), b.getE(), fbit.Carry);

            SumBitResult dbit = SumBit(a.getD(), b.getD(), ebit.Carry);
            SumBitResult cbit = SumBit(a.getC(), b.getC(), dbit.Carry);
            SumBitResult bbit = SumBit(a.getB(), b.getB(), cbit.Carry);
            SumBitResult abit = SumBit(a.getA(), b.getA(), bbit.Carry);

            

            return new MemoryUnit(abit.Result, bbit.Result, cbit.Result, dbit.Result, ebit.Result, fbit.Result, gbit.Result, hbit.Result);
        }

        private SumBitResult SumBit(bool firstBit, bool secondBit, bool carry)
        {
            if (firstBit && secondBit)
            {
                return new SumBitResult(carry, true);
            }
            else if (firstBit || secondBit)
            {
                return new SumBitResult(!carry, carry);
            }
            else
            {
                return new SumBitResult(carry, false);
            }
        }
    }
}
// 1 1 => CR = 1 ; R = 0
// 1 1 CR = 1 =>

    //if (carry)
    //                return new SumBitResult(true, true);
    //            else
    //                return new SumBitResult(false, true);

    //if (carry)
    //                return new SumBitResult(false, true);
    //            else
    //                return new SumBitResult(true, false);