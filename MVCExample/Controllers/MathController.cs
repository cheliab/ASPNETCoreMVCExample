using Microsoft.AspNetCore.Mvc;
using MVCExample.ControllersParams;

namespace MVCExample.Controllers
{
    public class MathController : Controller
    {
        public string Area(Geometry geometry)
        {
            return $"Площадь треугольника с основанием {geometry.Altitude} и высотой {geometry.Height} равна {geometry.GetArea()}";
        }
    }
}