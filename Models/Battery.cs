using System.Collections.Generic;

namespace Customer_Portal.Models
{
    public class Battery
    {
        public long? id { get; set; }
        public string battery_type { get; set; }
        public string information { get; set; }
        public long? building_id { get; set; }
        public long? employee_id { get; set; }
        public string status { get; set; }
        public string date_of_commissioning { get; set; }
        public string date_of_last_inspection { get; set; }
        public string certificate_of_operations { get; set; }
        public string notes { get; set; }
        public List<Column> columns { get; set; }
        public Building building { get; set; }
    }
}