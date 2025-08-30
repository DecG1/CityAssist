using CityAssist.Models;
using System.Collections.Concurrent;

namespace CityAssist.Services
{
    public class ReportService
    {
        private readonly ConcurrentQueue<Report> _reports = new();

        public void AddReport(Report report)
        {
            _reports.Enqueue(report);
        }

        public IEnumerable<Report> GetAllReports()
        {
            return _reports.ToList();
        }
    }
}
