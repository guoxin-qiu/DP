using Xunit;

namespace DP {
    public class SimpleFactoryTest {
        [Fact]
        public void TestAdd () {
            //Given
            Operation oper = OperationFactory.CreateOperation ("+");
            oper.NumberA = 3;
            oper.NumberB = 5;
            //When

            //Then
            Assert.Equal (8, oper.GetResult ());
        }
    }
}