// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗ 
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝ 
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗   
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝   
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗ 
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝ 
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Nest;
using System.Threading.Tasks;
using Tests.Domain;
using Tests.Framework.EndpointTests;

namespace Tests.Urls.SearchableSnapshots
{
    public class SearchableSnapshotsClearCacheUrlTests : UrlTestsBase
    {
        [U]
        public override async Task Urls()
        {
            await UrlTester.POST("/_searchable_snapshots/cache/clear").Request(c => c.SearchableSnapshots.ClearCache(new SearchableSnapshotsClearCacheRequest())).RequestAsync(c => c.SearchableSnapshots.ClearCacheAsync(new SearchableSnapshotsClearCacheRequest()));
        }
    }

    public class SearchableSnapshotsStatsUrlTests : UrlTestsBase
    {
        [U]
        public override async Task Urls()
        {
            await UrlTester.GET("/_searchable_snapshots/stats").Request(c => c.SearchableSnapshots.Stats(new SearchableSnapshotsStatsRequest())).RequestAsync(c => c.SearchableSnapshots.StatsAsync(new SearchableSnapshotsStatsRequest()));
        }
    }
}