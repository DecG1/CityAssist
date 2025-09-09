using CityAssist.Models;
using CityAssist.Services;
using Microsoft.AspNetCore.Mvc;

namespace CityAssist.Controllers
{
    public class IssueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        private readonly ReportService _reportService;

        public IssueController(ReportService reportService)
        {
            _reportService = reportService;
        }

        [HttpGet]
        public IActionResult Report()
        {
            var vm = new ReportViewModel
            {
                ExistingReports = _reportService.GetAllReports()
            };

            return View(vm);
        }

        [HttpPost]
        public IActionResult Report(IFormCollection form)
        {
            var report = new ReportModel
            {
                Location = form["Location"],
                Category = form["Category"],
                Description = form["Description"],
                Notification = form["Notification"] == "on",
                SubmitTime = DateTime.Now
            };

            var file = form.Files.GetFile("Media");
            if (file != null && file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                report.FileName = fileName;
               
            }

            _reportService.AddReport(report);

            return RedirectToAction("Report");
        }
    }
}
