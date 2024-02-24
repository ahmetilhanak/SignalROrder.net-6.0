﻿using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DtoLayer.BasketDto
{
    public class ResultBasketWithProductDto
    {
        public int BasketID { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public int ProductID { get; set; }       
        public string ProductName { get; set; }
        public int RestaurantTableID { get; set; }
        // public RestaurantTable RestaurantTable { get; set; }
    }
}
