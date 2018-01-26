using Xunit;

namespace DP {
    public class DecoratorTest {
        [Fact]
        public void Test () {
            //Given
            Person xc = new Person ("小菜");
            Sneakers sk = new Sneakers ();
            LeatherShoes ls = new LeatherShoes ();
            Necktie tie = new Necktie ();
            BigTrouser bt = new BigTrouser ();
            //When
            sk.Decorate (xc);
            ls.Decorate (sk);
            tie.Decorate (ls);
            bt.Decorate (tie);
            //Then
            bt.Show ();
            Assert.True (true);
        }
    }
}