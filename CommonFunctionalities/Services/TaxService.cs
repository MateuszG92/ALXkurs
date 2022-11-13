using CommonFunctionalities.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctionalities.Services
{
    public class TaxService:ITaxService
    {
        private const double VatPercentage = 0.23;
        private const double GovPercentage = 0.17;

        public double CalculateTax(double income)
        {
            var vatTax = CalculateVat(income);
            var govTax = CalculateGovTax(income,vatTax);
            return vatTax + govTax;
        }
        private double CalculateGovTax(double income,double vatTax)
        {
            return (income - vatTax) * GovPercentage;
        }
        private double CalculateVat(double income)
        {
            return income * VatPercentage;
        }
    }
}
