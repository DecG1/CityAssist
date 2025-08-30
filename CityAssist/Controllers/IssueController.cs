using Microsoft.AspNetCore.Mvc;

namespace CityAssist.Controllers
{
    public class IssueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Report()
        {
            var viewModel = new ReportPageViewModel
            {
                NewReport = new Report(),
                ExistingReports = _reportService.GetAllReports() // assuming a service pattern
            };

            return View(viewModel);
        }
    }
}
