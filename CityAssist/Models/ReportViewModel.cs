

namespace CityAssist.Models
{
    public class ReportViewModel
    {
        public ReportModel NewReport { get; set; } = new();
        public IEnumerable<ReportModel> ExistingReports { get; set; } = new List<ReportModel>();
    }
}
