namespace p6.Core.Entities
{
    public class DefaultEntitiesFactory : IEntitiesFactory
    {
        public IAccount NewAccount()
        {
            var account = new Account();
            return account;
        }
    }
}