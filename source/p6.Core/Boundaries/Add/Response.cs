namespace p6.Core.Boundaries.Add
{
    using System;
    public sealed class Response
    {
        public Guid AccountId { get; }
        public Response(Guid accountId)
        {
            AccountId = accountId;
        }

    }
}