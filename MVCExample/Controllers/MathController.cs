using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MVCExample.ControllersParams;

namespace MVCExample.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        /// <summary>
        /// Обработка сложных объектов в запросе
        /// 
        /// Пример:
        /// /Math/Area?Altitude=10&Height=5
        /// </summary>
        /// <param name="geometry"></param>
        /// <returns></returns>
        [HttpGet]
        public string Area(Geometry geometry)
        {
            return $"Площадь треугольника с основанием {geometry.Altitude} и высотой {geometry.Height} равна {geometry.GetArea()}";
        }

        /// <summary>
        /// Обработка параметров из Post запроса
        ///
        /// Пример:
        /// /Math/Index
        /// </summary>
        /// <param name="altitude"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [HttpPost]
        public string Area(int altitude, int height)
        {
            double square = altitude * height / 2;
            return $"Площадь треугольника с основанием {altitude} и высотой {height} равна {square}";
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