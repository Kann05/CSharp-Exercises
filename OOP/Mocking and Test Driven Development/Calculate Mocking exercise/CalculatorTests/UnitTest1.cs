using Mocking;
using Moq;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorTests
{
    public class Tests
    {
        [Test]
        public void TESTING_DIVIDING_RETURNS_DIVIDEDEXCEPTION()
        {

            var calculatorMock = new Mock<ICalculator>();
            calculatorMock.Setup(c => c.Divide(It.IsAny<int>(), 0)).Throws<System.DivideByZeroException>();
            var calculator = calculatorMock.Object;

            Assert.Throws<System.DivideByZeroException>(() => calculator.Divide(8, 0));
        }

        [Test]
        public void TESTING_DIVIDING_NUMBERS_RETURN_RESULT()
        {
            Mock<ICalculator> calculatorMock = new Mock<ICalculator>();
            calculatorMock.Setup(c => c.Divide(10, 2)).Returns(2);

            int result = calculatorMock.Object.Divide(10, 2);
            Assert.AreEqual(2, result);
        }

        [Test]
        public void TESTING_SUM2_NUMBERS_RETURN_RESULT()
        {
            Mock<ICalculator> calculatorMock = new Mock<ICalculator>();
            calculatorMock.Setup(c => c.Add(2, 3)).Returns(5);

            int result = calculatorMock.Object.Add(2, 3);

            Assert.AreEqual(5, result);
        }
    }
}