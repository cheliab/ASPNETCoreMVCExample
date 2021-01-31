using Microsoft.AspNetCore.Mvc;
using MVCExample.Utils;

namespace MVCExample.Controllers
{
    public class ActionResultController : Controller
    {
        
        /// <summary>
        /// Пример использования IActionResult
        /// 
        /// Пример:
        /// /ActionResult/GetHtmlResult
        /// </summary>
        /// <returns></returns>
        public HtmlResult GetHtmlResult()
        {
            return new HtmlResult("<h2>Привет ASP.NET 5</h2>");
        }

        /// <summary>
        ///
        /// Пример:
        /// /ActionResult/GetContentResult
        /// </summary>
        /// <returns></returns>
        public IActionResult GetContentResult()
        {
            return Content("Можно вывести какую то строку");
        }

        /// <summary>
        ///
        /// Пример:
        /// /ActionResult/GetJsonResult
        /// </summary>
        /// <returns></returns>
        public JsonResult GetJsonResult()
        {
            // Пример со строкой
            // return Json("Tom");
            
            // Пример с объектом
            UserData userData = new UserData{ Name ="Paha", Age = 30 };
            return Json(userData);
        }
    }
}