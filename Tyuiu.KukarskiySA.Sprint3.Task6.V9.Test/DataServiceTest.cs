using Tyuiu.KukarskiySA.Sprint3.Task6.V9.Lib;

namespace Tyuiu.KukarskiySA.Sprint3.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumTheDivisors_Range19To30_ReturnsCorrectResult()
        {
            // Arrange
            DataService dataService = new DataService();
            int startValue = 19, stopValue = 30;
            int expected = 53;

            // Act
            int actual = dataService.GetSumTheDivisors(startValue, stopValue);

            // Assert
            Assert.AreEqual(expected, actual, $"Ожидаемое значение {expected}, но получено {actual}");
        }
    }
}