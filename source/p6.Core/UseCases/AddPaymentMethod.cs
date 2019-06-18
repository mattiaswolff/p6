namespace p6.Core.UseCases
{
    using p6.Core.Boundaries;
    using p6.Core.Boundaries.AddPaymentMethod;
    using p6.Core.Gateways;

    public class AddPaymentMethod : IUseCase<Request>
    {
        private readonly IResponseHandler<Response> _responseHandler;
        private readonly IAccountGateway _accountGateway;
        public AddPaymentMethod(IResponseHandler<Response> responseHandler, IAccountGateway accountGateway)
        {
            _responseHandler = responseHandler;
            _accountGateway = accountGateway;
        }
        public void Execute(Request request)
        {
            var account = _accountGateway.Get(request.AccountId);
            account.AddPaymentMethod(request.Name, request.Token, request.ExpiresYear, request.ExpiresMonth, request.Last4);
            _accountGateway.Update(account);
            _responseHandler.Handle(new Response(account.Id));
        }
    }
}