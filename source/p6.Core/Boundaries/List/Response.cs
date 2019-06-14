namespace p6.Core.Boundaries.List
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public sealed class Response
    {
        public IReadOnlyCollection<Account> Accounts { get; }

        public Response(IList<Account> accounts)
        {
            Accounts = new ReadOnlyCollection<Account>(accounts);
        }
    }
}