using Tyuiu.KukarskiySA.Sprint3.Task2.V16.Lib;

namespace Tyuiu.KukarskiySA.Sprint3.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries_WithN2_Start1_Stop5_ReturnsCorrectResult()
        {
            // Arrange
            DataService dataService = new DataService();
            int n = 2; // Задаем n = 2
            int startValue = 1;
            int stopValue = 5;

            // Act
            double result = dataService.GetMultiplySeries(n, startValue, stopValue);

            // Assert
            double expected = 14400; // Ожидаемое значение для P = 1^2 * 2^2 * 3^2 * 4^2 * 5^2
            Assert.AreEqual(expected, result, 0.0001, "Значение не соответствует ожидаемому.");
        }
    }
}