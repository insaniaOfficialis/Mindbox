namespace MindBoxTests
{
    [TestClass]
    public class CircleTest
    {
        /// <summary>
        /// Проверка площади
        /// </summary>
        [TestMethod]
        public void GetSquare()
        {
            Figure figure = new Circle(2.3);
            var result = figure.GetArea();
            var correctResult = 16.61;

            Assert.AreEqual(correctResult, result);
        }

        /// <summary>
        /// Проверка исключения на пустые стороны
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "Радиус круга не может быть меньше или равен нулю")]
        public void EmptySide()
        {
            Figure circle = new Circle(0);
        }
    }
}
