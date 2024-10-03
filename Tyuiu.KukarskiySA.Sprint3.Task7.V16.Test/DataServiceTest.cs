using Tyuiu.KukarskiySA.Sprint3.Task7.V16.Lib;

namespace Tyuiu.KukarskiySA.Sprint3.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction_Test()
        {
            // Arrange
            DataService dataService = new DataService();

            double[] expectedValues = { -36.41, -22.07, 5.68, 16.72, 8.35, -0.5, 9.63, 16.29, 5.01, -22.4, -36.3 };


            // Act
            double[] actual = dataService.GetMassFunction(-5, 5);

            // Assert
            CollectionAssert.AreEqual(expectedValues, actual, "Массив значений функции не соответствует ожидаемому.");
        }


    }
}