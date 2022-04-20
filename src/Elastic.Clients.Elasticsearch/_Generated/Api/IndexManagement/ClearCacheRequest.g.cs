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
//
// ------------------------------------------------

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class ClearCacheRequestParameters : RequestParameters<ClearCacheRequestParameters>
	{
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Fielddata { get => Q<bool?>("fielddata"); set => Q("fielddata", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Query { get => Q<bool?>("query"); set => Q("query", value); }

		[JsonIgnore]
		public bool? Request { get => Q<bool?>("request"); set => Q("request", value); }
	}

	public partial class ClearCacheRequest : PlainRequestBase<ClearCacheRequestParameters>
	{
		public ClearCacheRequest()
		{
		}

		public ClearCacheRequest(Elastic.Clients.Elasticsearch.Indices? indices) : base(r => r.Optional("index", indices))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementClearCache;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.ExpandWildcards? ExpandWildcards { get => Q<Elastic.Clients.Elasticsearch.ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

		[JsonIgnore]
		public bool? Fielddata { get => Q<bool?>("fielddata"); set => Q("fielddata", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Fields? Fields { get => Q<Elastic.Clients.Elasticsearch.Fields?>("fields"); set => Q("fields", value); }

		[JsonIgnore]
		public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

		[JsonIgnore]
		public bool? Query { get => Q<bool?>("query"); set => Q("query", value); }

		[JsonIgnore]
		public bool? Request { get => Q<bool?>("request"); set => Q("request", value); }
	}

	public sealed partial class ClearCacheRequestDescriptor<TDocument> : RequestDescriptorBase<ClearCacheRequestDescriptor<TDocument>, ClearCacheRequestParameters>
	{
		internal ClearCacheRequestDescriptor(Action<ClearCacheRequestDescriptor<TDocument>> configure) => configure.Invoke(this);
		public ClearCacheRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementClearCache;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public ClearCacheRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
		public ClearCacheRequestDescriptor<TDocument> ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public ClearCacheRequestDescriptor<TDocument> Fielddata(bool? fielddata = true) => Qs("fielddata", fielddata);
		public ClearCacheRequestDescriptor<TDocument> Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
		public ClearCacheRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public ClearCacheRequestDescriptor<TDocument> Query(bool? query = true) => Qs("query", query);
		public ClearCacheRequestDescriptor<TDocument> Request(bool? request = true) => Qs("request", request);
		public ClearCacheRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			RouteValues.Optional("index", indices);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}

	public sealed partial class ClearCacheRequestDescriptor : RequestDescriptorBase<ClearCacheRequestDescriptor, ClearCacheRequestParameters>
	{
		internal ClearCacheRequestDescriptor(Action<ClearCacheRequestDescriptor> configure) => configure.Invoke(this);
		public ClearCacheRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementClearCache;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		public ClearCacheRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
		public ClearCacheRequestDescriptor ExpandWildcards(Elastic.Clients.Elasticsearch.ExpandWildcards? expandWildcards) => Qs("expand_wildcards", expandWildcards);
		public ClearCacheRequestDescriptor Fielddata(bool? fielddata = true) => Qs("fielddata", fielddata);
		public ClearCacheRequestDescriptor Fields(Elastic.Clients.Elasticsearch.Fields? fields) => Qs("fields", fields);
		public ClearCacheRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
		public ClearCacheRequestDescriptor Query(bool? query = true) => Qs("query", query);
		public ClearCacheRequestDescriptor Request(bool? request = true) => Qs("request", request);
		public ClearCacheRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			RouteValues.Optional("index", indices);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}