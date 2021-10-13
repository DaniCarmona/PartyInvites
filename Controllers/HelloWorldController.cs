﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvites.Controllers
{
    public class HelloWorldController : Controller
    {   
        //
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour; 

            if (hour >= 7 && hour <= 12)
            {
                ViewBag.Message = "Good Morning";
            }
            else if (hour >= 12 && hour <= 17)
            {
                ViewBag.Message = "Good Afternoon";
            }
            else if (hour >= 17 && hour <= 20)
            {
                ViewBag.Message = "Good Evening";
            }
            else
            {
                ViewBag.Message = "Good Night";
            }


            return View();
        }

        //
        // GET: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "This is my Welcome action method ...";
        }
    }
}
