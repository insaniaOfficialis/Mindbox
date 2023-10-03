namespace MindboxLibrary.Entities
{
    /// <summary>
    /// Фигура круга
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Константа Пи
        /// </summary>
        public const double Pi = 3.14;

        /// <summary>
        /// Конструктор круга
        /// </summary>
        /// <param name="r"></param>
        /// <exception cref="Exception"></exception>
        public Circle(double r) : base(Math.Round(Pi * r * r, 2))
        {
            if (r <= 0)
                throw new Exception("Радиус круга не может быть меньше или равен нулю");
        }
    }
}
