namespace p6.UnitTests.UseCaseTests
{
    using System;
    using p6.Core.Boundaries.AddPaymentMethod;
    using p6.Core.Entities;
    using p6.Core.UseCases;
    using p6.Infrastructure.InMemoryGateway;
    using Xunit;
    public class AddPaymentMethodUseCaseTests
    {
        string existingAccountId = "3b35f11e-7080-45e2-a152-afff5a325508";

        [Fact]
        public void GivenPaymentMethodAddedToAccount_ReturnAccountId()
        {
            InMemoryContext context = new InMemoryContext();
            InMemoryAccountGateway gateway = new InMemoryAccountGateway(context);
            var responseHandler = new ResponseHandler();
            var sut = new AddPaymentMethod(responseHandler, gateway);
            var name = "Visa";
            var token = "123409838";
            var expiresYear = 2020;
            var expiresMonth = 11;
            var last4 = "0394";
            var request = new Request(existingAccountId, name, token, expiresYear, expiresMonth, last4);

            sut.Execute(request);
            Assert.NotNull(responseHandler.AddPaymentMethod);
            Assert.Equal(existingAccountId, responseHandler.AddPaymentMethod[0].AccountId.ToString());
        }
    }
}