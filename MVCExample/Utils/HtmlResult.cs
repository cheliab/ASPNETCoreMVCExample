using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCExample.Utils
{
    public class HtmlResult : IActionResult
    {
        private string _htmlCode;

        public HtmlResult(string htmlCode)
        {
            _htmlCode = htmlCode;
        }
        
        public async Task ExecuteResultAsync(ActionContext context)
        {
            string fullHtmlCode = "<!DOCTYPE html><html><head>";
            fullHtmlCode += "<title>Главная страница</title>";
            fullHtmlCode += "<meta charset=utf-8 />";
            fullHtmlCode += "</head> <body>";
            fullHtmlCode += _htmlCode;
            fullHtmlCode += "</body></html>";
            
            await context.HttpContext.Response.WriteAsync(fullHtmlCode);
        }
    }
}