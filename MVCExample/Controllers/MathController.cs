using System;
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

        /// <summary>
        /// Пример получения параметров из объекта Request
        ///
        /// Пример:
        /// /Math/RequestObjectGetExample?altitude=6&height=6
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string RequestObjectGetExample()
        {
            string altitudeString = Request.Query.FirstOrDefault(p => p.Key == "altitude").Value;
            int altitude = Int32.Parse(altitudeString);

            string heightString = Request.Query.FirstOrDefault(p => p.Key == "height").Value;
            int height = Int32.Parse(heightString);

            double square = altitude * height / 2;
            
            return $"Площадь треугольника с основанием {altitude} и высотой {height} равна {square}";
        }

        /// <summary>
        /// Пример получение параметров из объекта Request
        ///
        /// Пример:
        /// Math/Index
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public string RequestObjectPostExample()
        {
            string altitudeString = Request.Form.FirstOrDefault(p => p.Key == "altitude").Value;
            int altitude = Int32.Parse(altitudeString);

            string heightString = Request.Form.FirstOrDefault(p => p.Key == "height").Value;
            int height = Int32.Parse(heightString);

            double square = altitude * height / 2;
            
            return $"Площадь треугольника с основанием {altitude} и высотой {height} равна {square}";
        }
    }
}