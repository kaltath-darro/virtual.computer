using Shouldly;
using VirtualComp.eu.virtualcomp.memory;
using VirtualComp.eu.virtualcomp.processor;
using Xunit;

namespace VirtualComp.Tests
{
    public class AdditionModuleFacts
    {
        private readonly AdditionModule additionModule;

        public AdditionModuleFacts()
        {
            additionModule = new AdditionModule();
        }

        [Fact]
        public void Add_InvokeWithOneandThree_ShouldBeFour()
        {
            MemoryUnit memoryUnit1 = new MemoryUnit(false, false, false, false, false, false,false, true);
            MemoryUnit memoryUnit2 = new MemoryUnit(false, false, false, false, false, false, true, true);

            MemoryUnit result = additionModule.Add(memoryUnit1, memoryUnit2);

            result.getA().ShouldBeFalse();
            result.getB().ShouldBeFalse();
            result.getC().ShouldBeFalse();
            result.getD().ShouldBeFalse();
            result.getE().ShouldBeFalse();
            result.getF().ShouldBeTrue();
            result.getG().ShouldBeFalse();
            result.getH().ShouldBeFalse();
        }




    }
}
