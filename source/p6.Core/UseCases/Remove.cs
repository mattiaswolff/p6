using p6.Core.Boundaries;
using p6.Core.Boundaries.Remove;
using p6.Core.Gateways;

namespace p6.Core.UseCases
{
    public sealed class Remove : IUseCase<Request>
    {
        private readonly IAccountGateway _accountGateway;

        public Remove(IAccountGateway accountGateway)
        {
            _accountGateway = accountGateway;
        }
        public void Execute(Request request)
        {
            _accountGateway.Delete(request.AccountId);
        }
    }
}