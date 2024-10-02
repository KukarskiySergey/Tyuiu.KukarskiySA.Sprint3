using Tyuiu.KukarskiySA.Sprint3.Task0.V24.Lib;

namespace Tyuiu.KukarskiySA.Sprint3.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void GetMultiplySeries_WithX5_Start1_Stop7_ReturnsCorrectResult()
        {
            // Arrange
            DataService dataService = new DataService();
            int x = 5;
            int startValue = 1;
            int stopValue = 7;

            // Act
            double result = dataService.GetMultiplySeries(x, startValue, stopValue);

            // Assert
            double expected = 0.1249; // Более точное значение
            Assert.AreEqual(expected, result, 0.0001, "Значение не соответствует ожидаемому.");
        }
    }
}