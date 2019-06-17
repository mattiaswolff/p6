namespace p6.UnitTests.UseCaseTests
{
    using System;
    using p6.Core.Boundaries.Add;
    using p6.Core.Entities;
    using p6.Core.UseCases;
    using p6.Infrastructure.InMemoryGateway;
    using Xunit;
    public sealed class GetUseCaseTests
    {
        string existingAccountId = "3b35f11e-7080-45e2-a152-afff5a325508";
        public void GivenAccountId_GetAccountObject()
        {
            //Arrange
            InMemoryContext context = new InMemoryContext();
            InMemoryAccountGateway gateway = new InMemoryAccountGateway(context);
            var responseHandler = new ResponseHandler();
            var get = new Get(responseHandler, gateway);
            //Act
            get.Execute(existingAccountId);
            //Assert
            Assert.NotNull(responseHandler.GetAccount);
        }
    }
}