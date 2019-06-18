namespace p6.Core.ValueObjects
{
    public class PaymentMethod
    {
        public string Name {get; private set;}
        public string Token {get; private set;}
        public int ExpiresYear {get; private set;}
        public int ExpiresMonth {get; private set;}
        public string Last4 {get; private set;}

        public PaymentMethod(string name, string token, int expiresYear, int expiresMonth, string last4)
        {
            Name = name;
            Token = token;
            ExpiresYear = expiresYear;
            ExpiresMonth = expiresMonth;
            Last4 = last4;
        }
    }
}