namespace p6.Core.Boundaries.Remove
{
    public sealed class Request : IRequest
    {
        public string AccountId { get; }

        public Request (string accountId)
        {
            AccountId = accountId;
        }
    }
}