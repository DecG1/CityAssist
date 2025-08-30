using CityAssist.Models;
using System.Collections.Concurrent;

namespace CityAssist.Services
{
    public class ReportService
    {
        
        private readonly ConcurrentDictionary<string, ReportModel> _reports = new();

        public void AddReport(ReportModel report)
        {
            var id = Guid.NewGuid().ToString();
            _reports[id] = report;
        }

        public IEnumerable<ReportModel> GetAllReports()
        {
            return _reports.Values;
        }
    }
}
