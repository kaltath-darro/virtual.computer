using Shouldly;
using VirtualComp.eu.virtualcomp.memory;
using Xunit;

namespace VirtualComp.Tests
{
    public class RAMFacts
    {
        private readonly RAM ram;

        public RAMFacts()
        {
            ram = new RAM();
            WordUnit unit = WordUnit.Create();
            unit.Set(MemoryUnit.Init(), MemoryUnit.Init(), MemoryUnit.Init(), new MemoryUnit(false, false, false, false, false, false, false, true));
            ram.Set(new MemoryUnit(false, false, false, false, false, false, false, true), unit);

            
        }

        [Fact]
        public void Set_WhenCalled_ShouldSetProperValueAtProperAddress()
        {
            RAM ram = new RAM();

            WordUnit unit = WordUnit.Create();
            unit.Set(MemoryUnit.Init(), MemoryUnit.Init(), MemoryUnit.Init(), new MemoryUnit(false, false, false, false, false, false, false, true));

            ram.Set(new MemoryUnit(false, false, false, false, false, false, false, true), unit);

            WordUnit result = ram.Get(new MemoryUnit(false, false, false, false, false, false, false, true));

            result.Byte4.getA().ShouldBe(false);
            result.Byte4.getB().ShouldBe(false);
            result.Byte4.getC().ShouldBe(false);
            result.Byte4.getD().ShouldBe(false);
            result.Byte4.getE().ShouldBe(false);
            result.Byte4.getF().ShouldBe(false);
            result.Byte4.getG().ShouldBe(false);
            result.Byte4.getH().ShouldBe(true);
        }

        [Fact]
        public void Set_WhenCalledTwiceWithSameAddressDifferentValue_ShouldSetProperValueAtProperAddress()
        {
            WordUnit unit = WordUnit.Create();
            unit.Set(MemoryUnit.Init(), MemoryUnit.Init(), MemoryUnit.Init(), new MemoryUnit(false, false, false, false, false, false, true, true));

            RAM ram = new RAM();
            ram.Set(new MemoryUnit(false, false, false, false, false, false, false, true), unit);

            WordUnit result = ram.Get(new MemoryUnit(false, false, false, false, false, false, false, true));

            result.Byte4.getA().ShouldBe(false);
            result.Byte4.getB().ShouldBe(false);
            result.Byte4.getC().ShouldBe(false);
            result.Byte4.getD().ShouldBe(false);
            result.Byte4.getE().ShouldBe(false);
            result.Byte4.getF().ShouldBe(false);
            result.Byte4.getG().ShouldBe(true);
            result.Byte4.getH().ShouldBe(true);

        }

        [Fact]
        public void Get_WhenCalled_ShouldReturnProperValue()
        {
            WordUnit result = ram.Get(new MemoryUnit(false, false, false, false, false, false, false, true));

            result.Byte4.getA().ShouldBe(false);
            result.Byte4.getB().ShouldBe(false);
            result.Byte4.getC().ShouldBe(false);
            result.Byte4.getD().ShouldBe(false);
            result.Byte4.getE().ShouldBe(false);
            result.Byte4.getF().ShouldBe(false);
            result.Byte4.getG().ShouldBe(false);
            result.Byte4.getH().ShouldBe(true);
        }
    }
}
