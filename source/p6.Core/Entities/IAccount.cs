namespace p6.Core.Entities
{
    using System;
    public interface IAccount
    {
        Guid Id { get; }
        string Name { get;  }
        void Rename(string name);
        void AddPaymentMethod(string name, string token, int expiresYear, int expiresMonth, string last4);
    }
}