using Microsoft.AspNetCore.Mvc.Filters;

namespace ActionFilter.Filters
{
    public class LogFilters : IActionFilter
    {
        // IActionResult İşlemleri bitirince çalışır.
        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine(context.ActionDescriptor.DisplayName + " Çalışması Bitti");
        }

        // IActionResult'dan hemen önce çalışır.
        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine(context.ActionDescriptor.DisplayName + " Çalışmaya Başladı");
        }
    }
}
