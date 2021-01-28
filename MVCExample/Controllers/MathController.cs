using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVCExample.ControllersParams;

namespace MVCExample.Controllers
{
    public class MathController : Controller
    {
        /// <summary>
        /// Обработка сложных объектов в запросе
        /// 
        /// Пример:
        /// /Math/Area?Altitude=10&Height=5
        /// </summary>
        /// <param name="geometry"></param>
        /// <returns></returns>
        public string Area(Geometry geometry)
        {
            return $"Площадь треугольника с основанием {geometry.Altitude} и высотой {geometry.Height} равна {geometry.GetArea()}";
        }

        /// <summary>
        /// Обработка массива параметров
        ///
        /// Пример:
        /// /Math/NumSum?nums=1&nums=2&nums=3
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public string NumSum(int[] nums)
        {
            return $"Сумма чисел равна {nums.Sum()}";
        }
    }
}