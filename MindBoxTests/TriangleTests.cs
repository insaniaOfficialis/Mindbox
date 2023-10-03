namespace MindBoxTests
{
    /// <summary>
    /// Тест треугольников
    /// </summary>
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// Проверка площади
        /// </summary>
        [TestMethod]
        public void GetSquare()
        {
            Figure figure = new Triangle(2.3, 3.4, 4.1);
            var result = figure.GetArea();
            var correctResult = 3.91;

            Assert.AreEqual(correctResult, result);
        }

        /// <summary>
        /// Проверка исключения на пустые стороны
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "У треугольника не может быть сторон меньше или равных нулю")]
        public void EmptySide()
        {
            Figure triangle = new Triangle(0, 3.4, 4.1);
        }

        /// <summary>
        /// Проверка исключения на корректность треугольника
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "У треугольника не может быть сторон меньше или равных нулю")]
        public void IncorrectTriangle()
        {
            Figure triangle = new Triangle(1.3, 3.4, 5.1);
        }

        /// <summary>
        /// Проверка на прямоугольность треугольника
        /// </summary>
        [TestMethod]
        public void GetIsRectangular()
        {
            var triangle = new Triangle(6, 8, 10);

            Assert.AreEqual(true, triangle.IsRectangular);
        }
    }
}