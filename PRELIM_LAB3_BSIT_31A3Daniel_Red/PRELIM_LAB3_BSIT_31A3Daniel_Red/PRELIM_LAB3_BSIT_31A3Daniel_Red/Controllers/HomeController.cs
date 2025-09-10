using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB3_BSIT_31A3Daniel_Red.Models;

namespace PRELIM_LAB3_BSIT_31A3Daniel_Red.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var customerList = new List<Customer>
        {
            new Customer
            {
                FirstName = "Alice",
                MiddleName = "B",
                LastName = "Carson",
                BirthDay = new DateTime(1996, 7, 10),
                CustomerId = 1001
            },
            new VipCustomer
            {
                FirstName = "Bob",
                MiddleName = "C",
                LastName = "Dylan",
                BirthDay = new DateTime(1988, 5, 20),
                CustomerId = 2001
            }
        };

        ViewBag.CustomerList = customerList;
        return View();
    }
}
