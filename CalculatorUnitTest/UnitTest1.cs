using AdditionLogic;
namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculationOperationTesting
    {
        [TestMethod]
        public void Adding_Two_Positive_Decimals()
        {
            double result = Addition.Add(4, 5);
            Assert.AreEqual(9, result);
        }
    }
}