using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

namespace ProxyKit
{
    internal static class UpstreamHostExtensions
    {
        internal static Uri BuildUpstreamUri(this UpstreamHost upstreamHost, PathString path, QueryString queryString) =>
            new Uri(UriHelper.BuildAbsolute(
                upstreamHost.Scheme,
                upstreamHost.Host,
                upstreamHost.PathBase,
                path, 
                queryString));
    }
}