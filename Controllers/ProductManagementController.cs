using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using Customer_Portal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerPortal.Controllers
{
    [Authorize]
    public class ProductManagementController : Controller
    {
        private readonly ILogger<ProductManagementController> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public ProductManagementController(ILogger<ProductManagementController> logger, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            // http response for batteries
            //Battery-->Customer ID = Endpoint
            var data = User.Identity.Name;
            HttpClient userbattery = new HttpClient();

            var buildingBattery = userbattery.GetStringAsync("https://rocket-elevators-rest-api-code.herokuapp.com/api/Batteries/" + data +"/battery").GetAwaiter().GetResult();

            Console.WriteLine(buildingBattery);

            List<Battery> userbatteries = JsonConvert.DeserializeObject<List<Battery>>(buildingBattery);

            ViewBag.batteries = userbatteries;


            //Column-->Customer ID = Endpoint
            HttpClient userColumn = new HttpClient();

            var customerColumn = userColumn.GetStringAsync("https://rocket-elevators-rest-api-code.herokuapp.com/api/Columns/" + data + "/column").GetAwaiter().GetResult();


            List<Column> userColumns = JsonConvert.DeserializeObject<List<Column>>(customerColumn);

            ViewBag.columns = userColumns;

            // Elevator-->Customer ID = Endpoint
            HttpClient userElevator = new HttpClient();

            var customerElevator = userElevator.GetStringAsync("https://rocket-elevators-rest-api-code.herokuapp.com/api/Elevators/"+data+"/elevator").GetAwaiter().GetResult();
            Console.WriteLine(customerElevator);


            List<Elevator> userElevators = JsonConvert.DeserializeObject<List<Elevator>>(customerElevator);

            ViewBag.elevators = userElevators;

            return View();
        }

    }
}