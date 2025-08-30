namespace CityAssist.Models
{
    public class ReportModel
    {

        public Guid ReportId { get; set; } = Guid.NewGuid();
        public string Location { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; } 
        public bool Notification { get; set; }

        public string Status { get; set; } = "Recieved";
        public DateTime SubmitTime { get; set; } = DateTime.Now;
    }
}
    

