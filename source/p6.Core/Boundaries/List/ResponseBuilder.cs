namespace p6.Core.Boundaries.List
{
    using System.Collections.Generic;
    using System;

    public sealed class ResponseBuilder
    {
        private IList<Account> _accounts;

        public ResponseBuilder()
        {
            _accounts = new List<Account>();
        }

        public Response Build()
        {
            var response = new Response(_accounts);
            return response;
        }
    }
}