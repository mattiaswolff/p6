namespace p6.Infrastructure.InMemoryGateway
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using p6.Core.Boundaries;
    using p6.Core.UseCases;

    public sealed class ResponseHandler : IResponseHandler<Core.Boundaries.List.Response>, IResponseHandler<Core.Boundaries.Add.Response>,
    IResponseHandler<Core.Boundaries.Get.Response>,
    IResponseHandler<Core.Boundaries.AddPaymentMethod.Response>
    {
        public Collection<Core.Boundaries.List.Response> ListAccounts { get; }
        public Collection<Core.Boundaries.Add.Response> AddAccounts { get; }
        public Collection<Core.Boundaries.Get.Response> GetAccount { get; }
        public Collection<Core.Boundaries.AddPaymentMethod.Response> AddPaymentMethod { get; }

        public ResponseHandler()
        {
            ListAccounts = new Collection<Core.Boundaries.List.Response>();
            AddAccounts = new Collection<Core.Boundaries.Add.Response>();
            GetAccount = new Collection<Core.Boundaries.Get.Response>();
            AddPaymentMethod = new Collection<Core.Boundaries.AddPaymentMethod.Response>();
        }

        public void Handle(Core.Boundaries.List.Response response)
        {
            ListAccounts.Add(response);
        }
        public void Handle(Core.Boundaries.Add.Response response)
        {
            AddAccounts.Add(response);
        }
        public void Handle(Core.Boundaries.Get.Response response)
        {
            GetAccount.Add(response);
        }
        public void Handle(Core.Boundaries.AddPaymentMethod.Response response)
        {
            AddPaymentMethod.Add(response);
        }
    }
}