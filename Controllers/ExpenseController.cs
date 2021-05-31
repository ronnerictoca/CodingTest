using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using CodingTest.Business;
using CodingTest.Common;

namespace CodingTest.Controllers
{
    public class ExpenseController : ApiController
    {
        public async Task<IHttpActionResult> Get([FromUri] CreateExpenseClaimRequest request)
        {
            var response = await ExpenseBusiness.CreateExpenseClaim(request);

            return Ok(response);
        }
    }
}
