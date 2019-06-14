namespace p6.UnitTests.UseCaseTests
{
    using p6.Core.UseCases;
    using p6.Infrastructure.InMemoryGateway;
    using Xunit;
    public sealed class ListUseCaseTests
    {
        [Fact]
        public void GivenContext_ReturnsAccounts()
        {
            //Assert
            var context = new InMemoryContext();
            var gateway = new InMemoryAccountGateway(context);
            var responseHandler = new ResponseHandler();
            var list = new List(responseHandler, gateway);
            //Act
            list.Execute();
            //Assert
            Assert.NotNull(responseHandler.ListAccounts);
        }
    }
}