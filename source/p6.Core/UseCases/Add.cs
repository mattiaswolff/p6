namespace p6.Core.UseCases
{
    using p6.Core.Gateways;
    using p6.Core.Boundaries;
    using p6.Core.Boundaries.Add;
    using p6.Core.Entities;
    using System;

    public sealed class Add
    {
        private readonly IResponseHandler<Response> _responseHandler;
        private readonly IAccountGateway _accountGateway;
        private readonly IEntitiesFactory _entitiesFactory;

        public Add(IResponseHandler<Response> responseHandler, IAccountGateway accountGateway, IEntitiesFactory entitiesFactory)
        {
            _responseHandler = responseHandler;
            _accountGateway = accountGateway;
            _entitiesFactory = entitiesFactory;
        }

        public void Execute(Request request)
        {
            if (request == null)
                throw new Exception("Request is null");

            if (string.IsNullOrWhiteSpace(request.Name))
                throw new Exception("Title is null");
                
            IAccount account = _entitiesFactory.NewAccount();
            account.Rename(request.Name);
            _accountGateway.Add(account);

            Response response = new Response(account.Id);
            _responseHandler.Handle(response);
        }
    }
}