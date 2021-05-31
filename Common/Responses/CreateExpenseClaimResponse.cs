using CodingTest.Common.Responses;

namespace CodingTest.Common
{
    public class CreateExpenseClaimResponse : Response
    {
        public ExpenseClaim ExpenseClaim { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}