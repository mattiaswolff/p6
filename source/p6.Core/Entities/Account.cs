using System;
using p6.Core.ValueObjects;

namespace p6.Core.Entities
{
    public class Account : IAccount
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public PaymentMethod PaymentMethod {get; private set;}

        public Account() {
            Id = Guid.NewGuid();
        }

        public void Rename (string name)
        {
            Name = name;
        }

        public static IAccount Restore(Guid accountId, string name)
        {
            Account restoredAccount = new Account();
            restoredAccount.Id = accountId;
            restoredAccount.Name = name;
            return restoredAccount;
        }

        public void AddPaymentMethod(string name, string token, int expiresYear, int expiresMonth, string last4)
        {
            var paymentMethod = new PaymentMethod(name, token, expiresYear, expiresMonth, last4);
            PaymentMethod = paymentMethod;
        }

    }
}