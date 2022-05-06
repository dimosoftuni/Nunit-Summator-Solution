using NUnit.Framework;

namespace Summator.Tests
{
    public class SummatorTests
    {
        [Test]
        public void Test_Sum_TwoPossitiveNumbers()
        {
            long actual = Summator.Sum(new int[] { 5, 7 });

            int expected = 12;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Sum_OnePositiveNumber()
        {
            long actual = Summator.Sum(new int[] { 5 });

            Assert.That(actual == 5);
        }

        [Test]
        public void Test_Sum_TwoNegativeNumbers()
        {
            long actual = Summator.Sum(new int[] { -7, -9 });

            Assert.That(actual == -16);
        }

        [Test]
        public void Test_Sum_EmptyArray()
        {
            long actual = Summator.Sum(new int[] { });

            Assert.That(actual == 0);
        }

        [Test]
        public void Test_Sum_BigValues()
        {
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(8000000000, actual);
        }

        [Test]
        public void Test_Average_TwoPossitiveNumbers()
        {
            double actual = Summator.Average(new int[] { 5, 7 });

            double expected = 6;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Average_TwoNegativeNumbers()
        {
            double actual = Summator.Average(new int[] { -5, -7 });

            double expected = -6;

            Assert.That(expected == actual);
        }

        [Test]
        public void Test_Average_WithOddSumAndEvenSeparator()
        {
            double actual = Summator.Average(new int[] { 6, 7 });

            double expected = 6.5;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Average_WithNegativeOddSumAndEvenSeparator()
        {
            double actual = Summator.Average(new int[] { -6, -7 });

            double expected = -6.5;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_SumOddOrEven_WithOddSum()
        {
            string oddSum = Summator.SumOddOrEven(new int[] { 6, 7 });

            string expected = "Sum result is odd!";

            Assert.AreEqual(expected, oddSum);
        }

        [Test]
        public void Test_SumOddOrEven_WithEvenSum()
        {
            string oddSum = Summator.SumOddOrEven(new int[] { 5, 7 });

            string expected = "Sum result is even!";

            Assert.AreEqual(expected, oddSum);
        }
    }
}