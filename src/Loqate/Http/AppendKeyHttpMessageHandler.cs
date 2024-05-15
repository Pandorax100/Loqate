using Loqate.Options;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;

namespace Loqate.Http;

internal class AppendKeyHttpMessageHandler(IOptions<LoqateOptions> options) : DelegatingHandler
{
    private readonly string _apiKey = options.Value.Key;

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        if (request.RequestUri is not null)
        {
            var query = QueryHelpers.ParseQuery(request.RequestUri.Query);

            query.Add("Key", _apiKey);

            string uriWithKey = QueryHelpers.AddQueryString(request.RequestUri.GetLeftPart(UriPartial.Path), query);

            request.RequestUri = new Uri(uriWithKey);
        }

        return base.SendAsync(request, cancellationToken);
    }
}
