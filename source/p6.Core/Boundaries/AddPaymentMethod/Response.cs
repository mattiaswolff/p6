namespace p6.Core.Boundaries.AddPaymentMethod
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