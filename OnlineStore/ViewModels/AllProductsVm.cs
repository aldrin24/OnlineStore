﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using OnlineStore.Models;

namespace OnlineStore.ViewModels
{
    public class AllProductsVm
    {
     
        public string Brand { get; set; }

  
        public string Make { get; set; }

        public decimal Price { get; set; }

        public ApplicationUser User { get; set; }
    }
}