using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CardTests
{
    [TestClass]
    public class UnitTest1
    {
        static DateTime cardExpDate = new DateTime(2020, 12, 1);
        Card card = new Card("4127785412347856", "1234", cardExpDate, 123, CardType.DEBIT);
        
        [TestMethod]
        //Checks login when Pin is correct. 
        public void checkPinTestCorrect()
        {        
                LogInProcess lg = new LogInProcess();
                lg.InsertCard(card);            
                bool result = lg.LogIn("1234");
                Assert.IsTrue(result);
        }

        [TestMethod]
        //Checks login if the card number is null.
        public void checkPinTestnull()
        {
            LogInProcess lg = new LogInProcess();
            lg.InsertCard(card);
            bool result = lg.LogIn(null);
            Assert.IsFalse(result);
        }

        [TestMethod]
        //Checks login if incorrect pin is entered.
        public void checkPinTestIncorrectPin()
        {
            LogInProcess lg = new LogInProcess();
            lg.InsertCard(card);
            bool result = lg.LogIn("1237");
            Assert.IsFalse(result);
        }

        [TestMethod]
        //checks if card is blocked after 3 incorrect attempts
        public void CheckPinBlocked()
        {
            LogInProcess lg = new LogInProcess();
            lg.InsertCard(card);
            lg.LogIn("1");
            lg.LogIn("1");
            lg.LogIn("1");
            Assert.IsTrue(card.IsBlocked); 
        }
    }
}
