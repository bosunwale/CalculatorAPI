using AdditionLogic;
namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculationOperationTesting
    {
        [TestMethod]
        [DataRow(5, 2.5, 7.5)]
        [DataRow(4,9,13)]
        public void Adding_Two_Positive_Numbers_and_return_Doubles(double leftNum, double rightNum, double expectedResult)
        {
            double result = Addition.Add(leftNum, rightNum);
            Assert.AreEqual(expectedResult, result);
        }
    }
}