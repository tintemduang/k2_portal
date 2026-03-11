namespace K2Portal.Models
{
    public class K2TaskResponse
    {
        public List<K2TaskItem>? Tasks { get; set; }
    }
    
    public class K2TaskItem
    {
        public string? SerialNumber { get; set; }

        public string? Status { get; set; }

        public DateTime? TaskStartDate { get; set; }

        public int Priority { get; set; }

        public string? FormURL { get; set; }

        public string? ViewFlowURL { get; set; }

        public string? WorkflowDisplayName { get; set; }

        public string? WorkflowInstanceFolio { get; set; }

        public string? ActivityName { get; set; }
    }
}