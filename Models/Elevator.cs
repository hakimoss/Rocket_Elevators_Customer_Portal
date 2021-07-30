namespace Customer_Portal.Models
{
    public class Elevator
    {
        public long id { get; set; }
        public long? column_id { get; set; }
        public string status { get; set; }
        public string serial_number { get; set; }
        public string model { get; set; }
        public string elevator_type { get; set; }
        public Column column { get; set; }
    }
}