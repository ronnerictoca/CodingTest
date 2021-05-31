using CodingTest.Common;
using CodingTest.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace CodingTest.Business
{
    public class ExpenseBusiness
    {
        public async static Task<CreateExpenseClaimResponse> CreateExpenseClaim(CreateExpenseClaimRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.EmailContent))
            {
                return new CreateExpenseClaimResponse { Success = false, Message = "Email text required" };
            }

            XDocument xml = ValidateXML(request.EmailContent);

            if (xml == null)
            {
                return new CreateExpenseClaimResponse { Success = false, Message = "Invalid Format" };
            }

            /* check total */

            /* check cost_centre */

            /* assign values to model */
            var expense = GetExpense(xml);

            decimal taxRate = GetTaxRate();
            
            var claim = Helper.Convert<ExpenseClaim>(expense);

            claim.Tax = CalculateTax(expense.Total, taxRate);
            claim.SubTotal = expense.Total - claim.Tax;

            return new CreateExpenseClaimResponse
            {
                Success = true,
                ExpenseClaim = claim
            };
        }

        #region Helpers
        private static XDocument ValidateXML(string emailContent)
        {
            return null;
        }

        private static Expense GetExpense(XDocument xml)
        {
            /* Sample Data */
            var expense = new Expense() {
                Id = Guid.NewGuid().ToString(),
                Vendor = "Viaduct Steakhouse",
                Description = "development team’s project end celebration dinner",
                Date = DateTime.ParseExact("Tuesday 27 April 2017", "D", CultureInfo.InvariantCulture),
                CostCentre = "DEV002",
                Total = 1024.01m,
                PaymentMethod = "personal card",
            };
            return expense;
        }

        private static decimal GetTaxRate()
        {
            /* Get Tax Rate from table */

            /* Sample Data */
            const decimal taxRate = 0.15m;

            return taxRate;
        }

        private static decimal CalculateTax(decimal total, decimal taxRate)
        {
            decimal tax = total * taxRate;
            return tax;
        }

        #endregion
    }
}