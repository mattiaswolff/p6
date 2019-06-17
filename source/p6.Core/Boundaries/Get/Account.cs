namespace p6.Core.Boundaries.Get
{
    using System;
    public sealed class Account
    {
        public Guid AccountId { get;  }
        public string Name { get; }

        public Account(Guid accountId, string name)
        {
            AccountId = accountId;
            Name = name;
        }
    }
}