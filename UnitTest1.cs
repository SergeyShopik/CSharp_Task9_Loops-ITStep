using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task9_library;

namespace C_sharp_task9_loops
{
    [TestClass]
    public class Task9Test
    {
        [TestMethod]
        public void SumDigitsOfTheNumberTest_1234_10()
        {
            int expected = 10;
            int seed = 1234;
            int actual = Task9.SumDigitsOfTheNumber(seed);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MultDigitsOfTheNumberTest_1234_24()
        {
            int expected = 24;
            int seed = 1234;
            int actual = Task9.MultDigitsOfTheNumber(seed);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckDigitsIncreaseTest_1234_true()
        {
            bool expected = true;
            bool actual = Task9.CheckDigitsIncrease(1234);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckDigitsDecreaseTest_1234_true()
        {
            bool expected = true;
            bool actual = Task9.CheckDigitsIncrease(1234);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void IsNumDecrOrIncrTest_6789_true()
        {
            bool expected = true;
            bool actual = Task9.IsNumDecrOrIncr(6789);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalcIncomePerMonthTest_deposit1000percent10_100()
        {
            double deposit = 1000;
            double percent = 10;

            double expected = 100;
            double actual = Task9.CalcIncomePerMonth(deposit, percent);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CalcTotalTest_total1000monthIncome100_1100()
        {
            double totalSum = 1000;
            double monthIncome = 100;

            double expected = 1100;
            double actual = Task9.CalcTotal(totalSum, monthIncome);
        }
        [TestMethod]
        public void CalcMonthToReachSumTest_sum2000percent10_8()
        {
            double sum = 2000;
            double percent = 10;

            int expected = 8;
            double actual = Task9.CalcMonthToReachSum(sum, percent);

            Assert.AreEqual(expected, actual);
        }
    }
}
