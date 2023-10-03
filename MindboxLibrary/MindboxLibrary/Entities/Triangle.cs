namespace MindboxLibrary.Entities
{
    /// <summary>
    /// Фигура треугольника
    /// </summary>
    public class Triangle : Figure
    {
        public bool IsRectangular { get; private set; } //атрибут признака прямоугольного треугольника

        /// <summary>
        /// Конструктор треугольника
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <exception cref="Exception"></exception>
        public Triangle(double side1, double side2, double side3) : base(
            Math.Round(Math.Sqrt((side1 + side2 + side3) / 2 * 
                ((side1 + side2 + side3) / 2 - side1) * 
                ((side1 + side2 + side3) / 2 - side2) * 
                ((side1 + side2 + side3) / 2 - side3)), 2))
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
                throw new Exception("У треугольника не может быть сторон меньше или равных нулю");

            if (side1 + side2 < side3 || side1 + side3 < side2 || side2 + side3 < side1)
                throw new Exception("Данная фигура не является треугольником");

            CheckIsRectangular(side1, side2, side3);
        }

        /// <summary>
        /// Метод проверки признака прямоугольного треугольника
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public void CheckIsRectangular(double side1, double side2, double side3)
        {
            double areaCathets = side1 * side1 + side2 * side2;
            double areaHypotenuse = side3 * side3;

            if (areaCathets == areaHypotenuse)
                IsRectangular = true;
        }
    }
}