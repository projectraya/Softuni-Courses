using ConsoleAppSumator;

namespace SummatorTests
{
    public class SummatorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            int sum = Summator.Sum(new int[] { 1, 2 });
            //Assert.AreEqual(3, sum);
            //more readable varinant for ^
            Assert.That(sum, Is.EqualTo(3));
        }

        [Test]
        public void Test2()
        {
            int[] input = new int[] { -2, 833333, 12 };

            int sum = Summator.Sum(input); //833343
            int multiplied = Summator.Multiplier(input); //-19 999 992

            Assert.That(sum, Is.GreaterThan(multiplied));
        }
    }
}