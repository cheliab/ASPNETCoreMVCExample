namespace MVCExample.ControllersParams
{
    public class Geometry
    {
        /// <summary>
        /// Основание треугольника
        /// </summary>
        public int Altitude { get; set; }
        
        /// <summary>
        /// Высота треугольника
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Площадь треугольника
        /// </summary>
        /// <returns></returns>
        public double GetArea()
        {
            return Altitude * Height / 2;
        }
    }
}