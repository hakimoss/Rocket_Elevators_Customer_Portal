using System.Collections.Generic;

namespace Customer_Portal.Models
{
    public class Building
    {
        public long id { get; set; }
        public string full_name_of_the_building_administrator { get; set; }
        public string email_of_the_administrator { get; set; }
        public string phone_number_of_the_building_administrator { get; set; }
        public string full_name_of_the_technical_contact_for_the_building { get; set; }
        public string technical_contact_email_for_the_building { get; set; }
        public string technical_contact_phone_for_the_building { get; set; }
        public long? customer_id { get; set; }
        public string address_of_the_building_id { get; set; }
        public List<Battery> batteries { get; set; }
        public Customer customer { get; set; }
        
        // public virtual Customer Customers { get; set; }
        //public Customer customer { get; set; }
    }
}