using System.Collections.Generic;

namespace Customer_Portal.Models
{
    public class Customer
    {
        public long id { get; set; }
        public string compagny_name { get; set; }
        public string full_name_of_the_company_contact { get; set; }
        public string company_contact_phone { get; set; }
        public string full_name_of_service_technical_authority { get; set; }
        public string technical_authority_phone_for_service { get; set; }
        public string technical_manager_email_for_service { get; set; } // Support name
        public string company_description { get; set; } // Support phone
        public string email_of_the_company_contact { get; set; } // Support email
        public List<Building> buildings { get; set; }
        // public virtual ICollection<Building> Buildings { get; set; }
    }
}