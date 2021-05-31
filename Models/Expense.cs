using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodingTest.Models
{
    public class Expense
    {
        public string Id { get; set; }
        public string Vendor { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string CostCentre { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Total { get; set; }
    }
}