using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web_API_Hands_on.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "errorlog.txt");
            File.AppendAllText(filePath, $"[{DateTime.Now}] {context.Exception.Message}{Environment.NewLine}");

            context.Result = new ObjectResult("An internal server error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}
