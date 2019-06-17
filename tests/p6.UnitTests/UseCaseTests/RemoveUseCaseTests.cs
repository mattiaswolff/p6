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
            IUseCase sut = new Remove(gateway);

            sut.Execute(existingAccountId);

            Assert.Empty(context.Accounts.Where(e => e.Id == new Guid(existingAccountId)));
        }
    }
}