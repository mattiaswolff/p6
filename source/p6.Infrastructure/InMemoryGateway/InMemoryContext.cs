namespace p6.Infrastructure.InMemoryGateway
{
    using System.Collections.ObjectModel;
    using System.Linq;
    using System;
    using p6.Core.Entities;
    public sealed class InMemoryContext
    {
        public Collection<IAccount> Accounts { get; set; }
        public InMemoryContext()
        {
            Accounts = new Collection<IAccount>();
            Accounts.Add(Account.Restore(new Guid("3b35f11e-7080-45e2-a152-afff5a325508"), "MyName"));
        }
    }
}