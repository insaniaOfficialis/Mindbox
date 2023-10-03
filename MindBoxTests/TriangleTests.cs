namespace MindBoxTests
{
    /// <summary>
    /// ���� �������������
    /// </summary>
    [TestClass]
    public class TriangleTests
    {
        /// <summary>
        /// �������� �������
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
        /// �������� ���������� �� ������ �������
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "� ������������ �� ����� ���� ������ ������ ��� ������ ����")]
        public void EmptySide()
        {
            Figure triangle = new Triangle(0, 3.4, 4.1);
        }

        /// <summary>
        /// �������� ���������� �� ������������ ������������
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(Exception), "� ������������ �� ����� ���� ������ ������ ��� ������ ����")]
        public void IncorrectTriangle()
        {
            Figure triangle = new Triangle(1.3, 3.4, 5.1);
        }

        /// <summary>
        /// �������� �� ��������������� ������������
        /// </summary>
        [TestMethod]
        public void GetIsRectangular()
        {
            var triangle = new Triangle(6, 8, 10);

            Assert.AreEqual(true, triangle.IsRectangular);
        }
    }
}