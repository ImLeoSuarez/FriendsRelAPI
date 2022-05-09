using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace friendsrelapi.Functions
{
    public partial class FriendsRelAPI
    {
        private readonly ExecutorProxy _executorProxy;
        public FriendsRelAPI(ExecutorProxy graphQlExecutorProxy)
        {
            _executorProxy = graphQlExecutorProxy;
        }

        [Function(nameof(GraphQL))]
        public async Task<HttpResponseData> GraphQL(
            [HttpTrigger(AuthorizationLevel.Anonymous, "post", Route = "graphql")] HttpRequestData req)
            => await _executorProxy.ExecuteQueryAsync(req).ConfigureAwait(false);
    }
}
