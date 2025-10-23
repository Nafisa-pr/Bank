using Bankclasslibrary;

namespace Tests 
{
    [TestClass]
    public class OverdraftAccountTests
    {
        private OverDraftAccount account;

        [TestInitialize]
        public void Setup()
        {
            account = new OverDraftAccount(
                "Harry Windsor",
                "33-44-55",
                "1111 2222 3333 4444",
                100
                );
        }

        [TestMethod]
        public void WithdrawWithinLimitTest()
        {
            account.Withdraw(120);
            Assert.AreEqual(-20, account.Balance);
        }

        [TestMethod]
        public void WithdrawOverLimitTest()
        {
            account.Withdraw(120);
            account.Withdraw(50);
            Assert.AreEqual(-20, account.Balance);

        }
    }
}

     