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
    }
}