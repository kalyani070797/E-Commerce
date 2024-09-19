
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Model.Ecommerces.Payments
{
    public class PaymentRequestModel
    {
        public int OrderId { get; set; }
        public string PaymentMethod { get; set; }
        [Precision(18, 2)]
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
