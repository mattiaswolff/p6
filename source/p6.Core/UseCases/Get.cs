
namespace p6.Core.UseCases
{
    using p6.Core.Boundaries;
    using p6.Core.Boundaries.Get;
    using p6.Core.Gateways;
    public sealed class Get : IUseCase<Request>
    {
        private readonly IResponseHandler<Response> _responseHandler;
        private readonly IAccountGateway _accountGateway;
        public Get(IResponseHandler<Response> responseHandler, IAccountGateway accountGateway)
        {
            _responseHandler = responseHandler;
            _accountGateway = accountGateway;
        }
        public void Execute(Request request)
        {
            var account = _accountGateway.Get(request.AccountId);
            Response response = new Response(account.Id, account.Name);
            _responseHandler.Handle(response);
        }
    }
}