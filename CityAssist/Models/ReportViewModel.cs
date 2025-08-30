

namespace CityAssist.Models
{
    public class ReportViewModel
    {
        public Report NewReport { get; set; } = new();
        public IEnumerable<Report> ExistingReports { get; set; } = new List<Report>();
    }
}
