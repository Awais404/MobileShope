﻿using System;
using System.Collections.Generic;

namespace MobileShope.Models
{
    public partial class Purchase
    {
        public int Id { get; set; }
        public int VendorId { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public int PricePerUnit { get; set; }
        public int TotalPrice { get; set; }
        public DateTime Date { get; set; }
    }
}
