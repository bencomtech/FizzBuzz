using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzServiceTest
    {
        private readonly FizzBuzzService service;

        public FizzBuzzServiceTest()
        {
            service = new FizzBuzzService();
        }

        [TestMethod]
        public void TestDevideByThreeShouldBeFizz()
        {
            string text = service.GetText(3);

            Assert.AreEqual("Fizz", text);
        }

        [TestMethod]
        public void TestDevideByFiveShouldBeBuzz()
        {
            string text = service.GetText(5);

            Assert.AreEqual("Buzz", text);
        }

        [TestMethod]
        public void TestDevideByThreeAndFiveShouldBeFizzBuzz()
        {
            string text = service.GetText(15);

            Assert.AreEqual("FizzBuzz", text);
        }

        [TestMethod]
        public void TestOtherCase()
        {
            string text = service.GetText(1);

            Assert.AreEqual("1", text);
        }
    }
}
