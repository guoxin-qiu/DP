using Xunit;

namespace DP {
    public class ProxyTest {
        [Fact]
        public void Test () {
            //Given
            var girl = new SchoolGirl ("Lucy");
            var proxy = new Proxy (girl);
            //When
            proxy.GiveDolls ();
            proxy.GiveChocolate ();
            proxy.GiveFlowers ();
            //Then
            Assert.True (true);
        }
    }
}