namespace p6.UnitTests.UseCaseTests
{
    using System;
    using p6.Core.Boundaries.Add;
    using p6.Core.Entities;
    using p6.Core.UseCases;
    using p6.Infrastructure.InMemoryGateway;
    using Xunit;
    public sealed class AddUseCaseTests
    {
        [Fact]
        public void GivenNullInput_ThrowsException()
        {
            var add = new Add(null, null, null);
            Assert.Throws<Exception>(() => add.Execute(null));
        }

        [Fact]
        public void GivenNullTitle_ThrowsException()
        {
            var request = new Core.Boundaries.Add.Request(null);
            var add = new Add(null, null, null);
            Assert.Throws<Exception>(() => add.Execute(request));
        }

        [Fact]
        public void GivenEmptyTitle_ThrowsException()
        {
            var request = new Request(string.Empty);
            var add = new Add(null, null, null);
            Assert.Throws<Exception>(() => add.Execute(request));
        }

        [Fact]
        public void GivenTitle_AccountWasAdded()
        {
            var context = new InMemoryContext();
            var gateway = new InMemoryAccountGateway(context);
            var entitiesFactory = new DefaultEntitiesFactory();
            var responseHandler = new ResponseHandler();

            var request = new Request("My Account Name");
            var add = new Add(responseHandler, gateway, entitiesFactory);
            
            add.Execute(request);
            Assert.Single(responseHandler.AddAccounts);
        }

        [Fact]
        public void GivenTitle_ReturnsId()
        {
            var context = new InMemoryContext();
            var gateway = new InMemoryAccountGateway(context);
            var entitiesFactory = new DefaultEntitiesFactory();
            var responseHandler = new ResponseHandler();
            
            var request = new Request("My Account Name");
            var add = new Add(responseHandler, gateway, entitiesFactory);
            
            add.Execute(request);
            Assert.True(Guid.Empty != responseHandler.AddAccounts[0].AccountId);
        }
    }
}