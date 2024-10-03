using Tyuiu.KukarskiySA.Sprint3.Task3.V12.Lib;

namespace Tyuiu.KukarskiySA.Sprint3.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMaxCharCount_WithConsecutiveK_ReturnsCorrectResult()
        {
            // Arrange
            DataService dataService = new DataService();
            string input = "bkkrk ckkkcs ksr";
            char item = 'k';
            int expected = 3; // ќжидаема€ максимальна€ последовательность 'k'

            // Act
            int actual = dataService.GetMaxCharCount(input, item);

            // Assert
            Assert.AreEqual(expected, actual, $"ќжидаемое значение {expected}, но получено {actual}");
        }

        [TestMethod]
        public void GetMaxCharCount_WithNoConsecutiveK_ReturnsOne()
        {
            // Arrange
            DataService dataService = new DataService();
            string input = "bk rk ck sc ks";
            char item = 'k';
            int expected = 1; // ћаксимальна€ последовательность 'k' Ч одиночные символы

            // Act
            int actual = dataService.GetMaxCharCount(input, item);

            // Assert
            Assert.AreEqual(expected, actual, $"ќжидаемое значение {expected}, но получено {actual}");
        }

        [TestMethod]
        public void GetMaxCharCount_WithNoK_ReturnsZero()
        {
            // Arrange
            DataService dataService = new DataService();
            string input = "abcdef";
            char item = 'k';
            int expected = 0; // ¬ строке нет символа 'k'

            // Act
            int actual = dataService.GetMaxCharCount(input, item);

            // Assert
            Assert.AreEqual(expected, actual, $"ќжидаемое значение {expected}, но получено {actual}");
        }

        [TestMethod]
        public void GetMaxCharCount_WithEmptyString_ReturnsZero()
        {
            // Arrange
            DataService dataService = new DataService();
            string input = "";
            char item = 'k';
            int expected = 0; // ѕуста€ строка Ч результат 0

            // Act
            int actual = dataService.GetMaxCharCount(input, item);

            // Assert
            Assert.AreEqual(expected, actual, $"ќжидаемое значение {expected}, но получено {actual}");
        }
    }
}