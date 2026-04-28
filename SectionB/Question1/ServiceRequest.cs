namespace Question1
{
    public class ServiceRequest
    {
        public Resident Resident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }   // 1–5
        public int SeverityLevel { get; set; }   // 1–10
        public int EstimatedResolutionHours { get; set; }
        public bool IsProcessed { get; set; }

        public ServiceRequest(Resident resident, string requestType, int priorityLevel, int severityLevel, int estimatedResolutionHours)
        {
            Resident = resident;
            RequestType = requestType;
            PriorityLevel = priorityLevel;
            SeverityLevel = severityLevel;
            EstimatedResolutionHours = estimatedResolutionHours;
            IsProcessed = false;
        }
    }
}