
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Identity;
using System.Text;
using System.Net;
using System.IO;
using Customer_Portal.Areas.Identity.Data;
using Customer_Portal.Models;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using System.Web;
namespace Customer_Portal.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductService _productService = new ProductService();
        private readonly UserManager<IdentityUser> _userManager; // Added/Injection UserManager to find the current logged user

        public HomeController(
            ILogger<HomeController> logger,
            UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _userManager = userManager; // code for UserManager from Areas\Identity\Pages\Account\Manage\ChangePassword.cshtml.cs
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Action to render the Intervention Form page
        public IActionResult Intervention(string elevatorSerialNumber, string columnId, string elevatorId, string buildingId, string batteryId)
        {
            var user_email = _userManager.GetUserName(User);
            var customer = _productService.getFullCustomerInfo(user_email);

            ViewBag.elevatorSerialNumber = elevatorSerialNumber;
            ViewBag.column = columnId;
            ViewBag.elevatorId = elevatorId;
            ViewBag.buildingId = buildingId;
            ViewBag.batteryId = batteryId;
            ViewBag.customer = customer;

            return View("~/Views/Home/Intervention.cshtml");
        }
        // Action to render the Update Customer Form page
        public IActionResult UpdateCustomer()
        {
            var user_email = _userManager.GetUserName(User);
            var customer = _productService.getFullCustomerInfo(user_email);

            ViewBag.customer = customer;

            return View();
        }

        // Action to render the Update Customer Form page

        // Action to render the Products page
        public IActionResult Product()
        {
            var customerInfoProduct = getFullCustomerInfo();
            ViewBag.customer = customerInfoProduct;

            return View(customerInfoProduct);
        }
        // public Customer getFullData(string email)
        // {
        //     var result = _httpClient.GetAsync("https://rocket-elevators-rest-api-code.herokuapp.com/api/Customers/" + email).Result;
        //     var contentBody = result.Content.ReadAsStringAsync().Result;
        //     // Console.WriteLine(" ======================== ");
        //     // Console.WriteLine(contentBody);
        //     // Console.WriteLine(" ======================== ");
        //     var myobjList = JsonConvert.DeserializeObject<List<Customer>>(contentBody);
        //     // Customer customer = JsonConvert.DeserializeObject<Customer>(contentBody);
        //     var customer = myobjList[0];
        //     // Console.WriteLine(building);
        // }
        // ========== Function to get all the data from the customer that is logged at the portal using the email ========================================
        // /Home/getFullCustomerInfo
        public IActionResult getFullCustomerInfo()
        {
            var user_email = _userManager.GetUserName(User); 
            Console.WriteLine("email: " + user_email);

            var customer =  _productService.getFullCustomerInfo(user_email);

            Console.WriteLine("Called getFullCustomerInfo");

            _logger.LogInformation(" !!! CALLED FUNCTION getFullCustomerInfo !!! ");

            return View("~/Views/Home/Products.cshtml", customer);
        }
    }
}
