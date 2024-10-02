using Tyuiu.KukarskiySA.Sprint3.Task1.V24.Lib;

namespace Tyuiu.KukarskiySA.Sprint3.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void GetSumSeries_WithX5_Start1_Stop12_ReturnsCorrectResult()
        {
            // Arrange
            DataService dataService = new DataService();
            int x = 5;
            int startValue = 1;
            int stopValue = 12;

            // Act
            double result = dataService.GetSumSeries(x, startValue, stopValue);

            // Assert
            double expected = 0.222; // Обновленное ожидаемое значение с точностью до 3-х знаков после запятой
            Assert.AreEqual(expected, result, 0.0001, "Значение не соответствует ожидаемому.");
        }
    }
}