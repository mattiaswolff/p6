namespace p6.UnitTests.UseCaseTests
{
    using System.Linq;
    using System;
    using p6.Infrastructure.InMemoryGateway;
    using Xunit;
    using p6.Core.Boundaries.Remove;
    using p6.Core.UseCases;

    public class RemoveUseCaseTests
    {
        string existingAccountId = "3b35f11e-7080-45e2-a152-afff5a325508";

        [Fact]
        public void GivenAccountId_RemoveAccount()
        {
            var context = new InMemoryContext();
            var gateway = new InMemoryAccountGateway(context);
            var sut = new Remove(gateway);
            var request = new Request(existingAccountId);
            sut.Execute(request);

            Assert.Empty(context.Accounts.Where(e => e.Id == new Guid(existingAccountId)));
        }
    }
}