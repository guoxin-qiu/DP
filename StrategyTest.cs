using Xunit;

namespace DP {
    public class StrategyTest {
        [Fact]
        public void Test () {
            //Given
            CashContext cashContext = new CashContext ("满300减100");
            double totalPrice = 0.0d;
            //When
            totalPrice = cashContext.GetResult (960d);
            //Then
            Assert.Equal (660, totalPrice);
        }
    }
}