using Tyuiu.KukarskiySA.Sprint3.Task4.V16.Lib;

namespace Tyuiu.KukarskiySA.Sprint3.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Calculate_WithRangeMinus5To5_ReturnsCorrectResult()
        {
            // Arrange
            DataService dataService = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double expected = 6.719;

            // Act
            double actual = dataService.Calculate(startValue, stopValue);

            // Assert
            Assert.AreEqual(expected, actual, 0.0001, $"Ожидаемое значение {expected}, но получено {actual}");
        }
    }
}