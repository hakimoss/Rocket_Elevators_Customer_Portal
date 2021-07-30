using System.Collections.Generic;

namespace Customer_Portal.Models
{
    public class Column
    {
        public long? id { get; set; }

        public long? battery_id { get; set; }
        public string status { get; set; }
        public string column_type { get; set; }
        public string information { get; set; }
        public long? number_of_floors_served { get; set; }
        public List<Elevator> elevators { get; set; }
        public Battery battery { get; set; }
    }
}