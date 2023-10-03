namespace MindboxLibrary.Entities
{
    /// <summary>
    /// Базовыц класс фигуры
    /// </summary>
    public class Figure
    {
        /// <summary>
        /// Атрибут площади
        /// </summary>
        private double Area;

        /// <summary>
        /// Конструктор фигуры
        /// </summary>
        /// <param name="area"></param>
        public Figure(double area) 
        {
            Area = area;
        }

        /// <summary>
        /// Метод возвращения площади
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Area;
        }
    }
}
