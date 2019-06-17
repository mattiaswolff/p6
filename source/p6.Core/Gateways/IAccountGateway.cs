namespace p6.Core.Gateways
{
    using System.Collections.Generic;
    using p6.Core.Entities;

    public interface IAccountGateway
    {
        IList<IAccount> List();
        void Add(IAccount account);

        IAccount Get(string accountId);

        void Delete(string accountId);
    }
}