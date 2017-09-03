﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Blip.Entities.Customers;
using Blip.Entities.Orders;

namespace Blip.Entities.Orders.ViewModels
{
    public class CustomerOrdersListViewModel
    {
        [Display(Name = "Customer Number")]
        public Guid CustomerID { get; set; }

        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Country")]
        public string CountryNameEnglish { get; set; }

        [Display(Name = "Region")]
        public string RegionNameEnglish { get; set; }

        public List<OrderDisplayViewModel> Orders { get; set; }
    }
}
