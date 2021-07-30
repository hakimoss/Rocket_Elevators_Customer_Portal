namespace Customer_Portal.Models
{
    public class Intervention
    {

        public long id { get; set; }
        public long author_id { get; set; } // Now the Author is the same as CustomerId
        public long customer_id { get; set; }
        public long building_id { get; set; }
        public long battery_id { get; set; }
        public long column_id { get; set; }
        public long elevator_id { get; set; }
        public long employee_id { get; set; }
        public string report { get; set; }        


        //"author":3,"customer_id":5,"building_id":8,"battery_id":14,"column_id":22,"elevator_id":45,"employee_id":5,"start_date_time":null,"end_date_time":null,"result":"Incomplete","report":"6 months checkup","status":"Pending","created_at":"2020-11-19T17:59:48","updated_at":"2020-11-19T17:59:48"}
    }
}