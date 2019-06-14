namespace p6.Core.Gateways
{
    using System.Collections.Generic;
    using p6.Core.Entities;

    public interface IAccountGateway
    {
        IList<IAccount> List();
        void Add(IAccount account);
        void Delete(string accountId);
    }
}