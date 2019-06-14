namespace p6.Core.UseCases
{
    using System.Collections.Generic;
    using p6.Core.Boundaries.List;
    using p6.Core.Boundaries;
    using p6.Core.Entities;
    using p6.Core.Gateways;

    public sealed class List : IUseCase
    {
        private IResponseHandler<Response> _responseHandler;
        private IAccountGateway _accountGateway;

        public List(
            IResponseHandler<Response> responseHandler,
            IAccountGateway accountGateway)
        {
            _responseHandler = responseHandler;
            _accountGateway = accountGateway;
        }

        public void Execute()
        {
            var accounts = _accountGateway.List();
            Response response = BuildResponse(accounts);
            _responseHandler.Handle(response);
        }

        private Response BuildResponse(IList<IAccount> accounts)
        {
            ResponseBuilder builder = new ResponseBuilder();
            //Probably need to do something more with this response builder
            return builder.Build();
        }
    }
}