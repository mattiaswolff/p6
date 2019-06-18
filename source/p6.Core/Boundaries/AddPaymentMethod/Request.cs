using System;

namespace p6.Core.Boundaries.AddPaymentMethod
{
    public class Request : IRequest
    {
        public string AccountId {get;}
        public string Name {get;}
        public string Token {get;}
        public int ExpiresYear {get;}
        public int ExpiresMonth {get;}
        public string Last4 {get;}

        public Request (string accountId, string name, string token, int expiresYear, int expiresMonth, string last4)
        {
            AccountId = accountId;
            Name = name;
            Token = token;
            ExpiresYear = expiresYear;
            ExpiresMonth = expiresMonth;
            Last4 = last4;
        }
    }
}