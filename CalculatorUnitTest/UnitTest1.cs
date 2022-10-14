using AdditionLogic;
using MultiplicationLogic;
using SubtractionLogic;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculationOperationTesting
    {
        //Test for adding positive numbers and returning double
        [TestMethod]
        [DynamicData(nameof(GetPositiveNumbersToAdd), DynamicDataSourceType.Method)]
        public void Adding_Two_Positive_Numbers_and_return_Doubles(double leftNum, double rightNum, double expectedResult)
        {
            double result = Addition.Add(leftNum, rightNum);
            Assert.AreEqual(expectedResult, result);
        }

        //Dynamic method to test positive numbers for addition
        private static IEnumerable<Object[]> GetPositiveNumbersToAdd()
        {
            var list = new List<Object[]>();
            for(int i=0; i<10; i++)
            {
                Random random = new Random();
                var leftNum = random.NextDouble() * random.NextInt64();
                var rightNum = random.NextDouble() * random.NextInt64();
                var expectedResult = leftNum + rightNum;
                if(expectedResult > 0)
                    list.Add(new Object[] { leftNum, rightNum, expectedResult});
            }
            return list;
        }

        //Test for subtracting positive numbers and returning double
        [TestMethod]
        [DynamicData(nameof(GetPositiveNumbersToSubtract), DynamicDataSourceType.Method)]
        public void Subtracting_Two_Positive_Numbers_and_return_Doubles(double leftNum, double rightNum, double expectedResult)
        {
            double result = Subtraction.Subtract(leftNum, rightNum);
            Assert.AreEqual(expectedResult, result);
        }
        //Dynamic Method to test positive numbers for subtraction
        private static IEnumerable<Object[]> GetPositiveNumbersToSubtract()
        {
            var list = new List<Object[]>();
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                var leftNum = random.NextDouble() * random.NextInt64();
                var rightNum = random.NextDouble() * random.NextInt64();
                var expectedResult = leftNum - rightNum;
                if (expectedResult > 0)
                {
                    list.Add(new Object[] { leftNum, rightNum, expectedResult });
                }
                else
                {
                    i--;
                }  
            }
            return list;
        }

        //Test for subtracting positive numbers and returning double
        [TestMethod]
        [DynamicData(nameof(GetPositiveNumbersToMultiply), DynamicDataSourceType.Method)]
        public void Multiplication_of_Two_Positive_Numbers_and_return_Doubles(double leftNum, double rightNum, double expectedResult)
        {
            double result = Multiplication.Multiply(leftNum, rightNum);
            Assert.AreEqual(expectedResult, result);
        }
        //Dynamic Method to test positive numbers for multiplication
        private static IEnumerable<Object[]> GetPositiveNumbersToMultiply()
        {
            var list = new List<Object[]>();
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                var leftNum = random.NextDouble() * random.NextInt64();
                var rightNum = random.NextDouble() * random.NextInt64();
                var expectedResult = leftNum * rightNum;
                if (expectedResult > 0)
                {
                    list.Add(new Object[] { leftNum, rightNum, expectedResult });
                }
                else
                {
                    i--;
                }
            }
            return list;
        }
    }
}