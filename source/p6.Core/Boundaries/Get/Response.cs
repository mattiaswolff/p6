namespace p6.Core.Boundaries.Get
{
    using System;

    public sealed class Response
    {
        private Account _account;

        public Response(Guid accountId, string name)
        {
            _account = new Account(accountId, name);
        }

    }
}