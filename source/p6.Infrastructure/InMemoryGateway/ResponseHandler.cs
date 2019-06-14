namespace p6.Infrastructure.InMemoryGateway
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using p6.Core.Boundaries;
    using p6.Core.UseCases;

    public sealed class ResponseHandler : IResponseHandler<Core.Boundaries.List.Response>, IResponseHandler<Core.Boundaries.Add.Response>
    {
        public Collection<Core.Boundaries.List.Response> ListAccounts { get; }
        public Collection<Core.Boundaries.Add.Response> AddAccounts { get; }

        public ResponseHandler()
        {
            ListAccounts = new Collection<Core.Boundaries.List.Response>();
            AddAccounts = new Collection<Core.Boundaries.Add.Response>();
        }

        public void Handle(Core.Boundaries.List.Response response)
        {
            ListAccounts.Add(response);
        }
        public void Handle(Core.Boundaries.Add.Response response)
        {
            AddAccounts.Add(response);
        }
    }
}