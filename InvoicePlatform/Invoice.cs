using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicePlatform
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string SeriesNumber { get; set; }
        public string CompanyName { get; set; }
        public int NIPNumber { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public decimal Amount { get; set; }
    }
}
