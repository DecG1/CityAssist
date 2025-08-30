using CityAssist.Models;
using System.Collections.Concurrent;

namespace CityAssist.Services
{
    public class ReportService
    {
        private readonly ConcurrentQueue<ReportModel> _reports = new();

        public void AddReport(ReportModel report)
        {
            _reports.Enqueue(report);
        }

        public IEnumerable<ReportModel> GetAllReports()
        {
            return _reports.ToList();
        }
    }
}
