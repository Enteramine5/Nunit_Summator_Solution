using NUnit.Framework;

namespace Summator.Tests
{
    public class Tests
    {
        [Test]
        public void Test_Sum_TwoPositiveNumbers()
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
            long actual = Summator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(6000000000, actual);
        }
        [Test]
        public void Test_Average_TwoPositiveNumbers()
        {
            double actual = Summator.Average(new double[] { 5, 7 });
            double expected = 6;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Average_TwoNegativeNumbers()
        {
            double actual = Summator.Average(new double[] { -5, -7 });
            double expected = -6;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Average_PositiveAndNegativeNumbers()
        {
            double actual = Summator.Average(new double[] { 5, -7 });
            double expected = -1;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Average_EmptyArray()
        {
            double actual = Summator.Average(new double[] { });
            double expected = double.NaN;
            Assert.That(expected, Is.EqualTo(actual));
        }
        [Test]
        public void Test_Average_FloatingResult()
        {
            double actual = Summator.Average(new double[] { 5, 8});
            double expected = 6.5;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Average_DoubleAndIntNumbers()
        {
            double actual = Summator.Average(new double[] { 8.5, 9 });
            double expected = 8.75;
            Assert.That(expected == actual);
        }
        [Test]
        public void Test_Average_BigValues()
        {
            double actual = Summator.Average(new double[] { 2000000000, 2000000000, 2000000000 });

            Assert.AreEqual(2000000000, actual);
        }
        [Test]
        public void Test_Sum_BigDoubleAndIntegerValues()
        {
            double actual = Summator.Average(new double[] {2000000000.0, 2000000000, 2000000000 });

            Assert.AreEqual(2000000000.0, actual);
        }
    }
}
