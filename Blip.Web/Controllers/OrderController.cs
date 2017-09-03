﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Blip.Data.Orders;
using Blip.Entities.Orders.ViewModels;

namespace BlipProjects.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index(string customerid)
        {
            if(!String.IsNullOrWhiteSpace(customerid))
            {
                if (Guid.TryParse(customerid, out Guid customerId))
                {
                    var repo = new OrdersRepository();
                    var model = repo.GetCustomerOrdersDisplay(customerId);
                    return View(model);
                }
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
    }
}