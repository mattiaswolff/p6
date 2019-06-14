using System;

namespace p6.Core.Entities
{
    public class Account : IAccount
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

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

    }
}