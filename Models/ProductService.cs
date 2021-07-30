using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Customer_Portal.Models
{
    public class ProductService 
    {
        private readonly ILogger<ProductService> _logger;


        private readonly HttpClient _httpClient = new HttpClient();

        public ProductService()
        {
            var serviceProvider = new ServiceCollection()
                      .AddLogging() //<-- You were missing this
                      .BuildServiceProvider();
            _logger = serviceProvider.GetService<ILoggerFactory>()
                        .CreateLogger<ProductService>();
        }

        // // ========== Function that calls endpoint /api/Customers/id to get all the data from the customer that is logged at the portal ============
        public Customer getFullCustomerInfo(string email)
        {
            var result = _httpClient.GetAsync("https://rocket-elevators-rest-api-code.herokuapp.com/api/Customers/" + email).Result;
            var contentBody = result.Content.ReadAsStringAsync().Result;
            // Console.WriteLine(" ======================== ");
            // Console.WriteLine(contentBody);
            // Console.WriteLine(" ======================== ");
            var myobjList = JsonConvert.DeserializeObject<List<Customer>>(contentBody);
            // Customer customer = JsonConvert.DeserializeObject<Customer>(contentBody);
            var customer = myobjList[0];
            // Console.WriteLine(building);
            _logger.LogInformation("customer email: {}", customer.email_of_the_company_contact);
            _logger.LogInformation("customer buildings: {}", customer.buildings);
            Console.WriteLine(" ============ all the CUSTOMER infos are here!!! ============ ");
            // Console.WriteLine(building.Id);
            // Console.WriteLine(building.email_of_the_company_contact);

            return customer;
        }

        //------------------------------ TEST ------------------------------
        public void helloWorld() //Test
        {
            _logger.LogInformation("Hello World!!!");
            Console.WriteLine("Hello again");
        }
        //------------------------------------------------------------------
    }
}