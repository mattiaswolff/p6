namespace p6.Infrastructure.InMemoryGateway
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System;
    using p6.Core.Entities;
    using p6.Core.Gateways;
    public sealed class InMemoryAccountGateway : IAccountGateway
    {
        private readonly InMemoryContext _context;

        public InMemoryAccountGateway (InMemoryContext context) {
            _context = context;
        }

        public IList<IAccount> List()
        {
            return _context.Accounts.ToList();
        }

        public void Add(IAccount account) 
        {
            _context.Accounts.Add(account);
        }
        public IAccount Get(string accountId) 
        {
            return _context.Accounts.Where(e => e.Id.ToString().Equals(accountId)).SingleOrDefault();
        }
        public void Delete(string accountId)
        {
            IAccount existingAccount = _context.Accounts.Where(e => e.Id.ToString().Equals(accountId)).SingleOrDefault();
            _context.Accounts.Remove(existingAccount);
        }
        public void Update(IAccount account)
        {
            IAccount existingAccount = _context.Accounts.Where(e => e.Id.ToString().Equals(account.Id)).SingleOrDefault();
            existingAccount = account;
        }
    }
}