namespace Atm.Tests
{
    [TestClass]
    public class AtmTest
    {
        [TestMethod]
        public void ShouldReturnCorrectlyAmountWhenHaveMoney()
        {
            Atm atm = new();
            Assert.AreEqual(@"2 bills of 200.1 bill of 20.1 bill of 10.2 coins of 2.", atm.Withdraw(434));

        }
    }
}