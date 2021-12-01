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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Aggregations
{
	public partial class FiltersAggregation : Aggregations.BucketAggregationBase, IAggregationContainerVariant
	{
		public FiltersAggregation(string name) : base(name)
		{
		}

		[JsonIgnore]
		string Aggregations.IAggregationContainerVariant.AggregationContainerVariantName => "filters";
		[JsonInclude]
		[JsonPropertyName("filters")]
		public Elastic.Clients.Elasticsearch.Aggregations.Buckets<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? Filters { get; set; }

		[JsonInclude]
		[JsonPropertyName("other_bucket")]
		public bool? OtherBucket { get; set; }

		[JsonInclude]
		[JsonPropertyName("other_bucket_key")]
		public string? OtherBucketKey { get; set; }

		[JsonInclude]
		[JsonPropertyName("keyed")]
		public bool? Keyed { get; set; }
	}

	public sealed partial class FiltersAggregationDescriptor : DescriptorBase<FiltersAggregationDescriptor>
	{
		public FiltersAggregationDescriptor()
		{
		}

		internal FiltersAggregationDescriptor(Action<FiltersAggregationDescriptor> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Aggregations.Buckets<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? FiltersValue { get; private set; }

		internal bool? OtherBucketValue { get; private set; }

		internal string? OtherBucketKeyValue { get; private set; }

		internal bool? KeyedValue { get; private set; }

		internal Dictionary<string, object>? MetaValue { get; private set; }

		internal string? NameValue { get; private set; }

		public FiltersAggregationDescriptor Filters(Elastic.Clients.Elasticsearch.Aggregations.Buckets<Elastic.Clients.Elasticsearch.QueryDsl.QueryContainer>? filters) => Assign(filters, (a, v) => a.FiltersValue = v);
		public FiltersAggregationDescriptor OtherBucket(bool? otherBucket = true) => Assign(otherBucket, (a, v) => a.OtherBucketValue = v);
		public FiltersAggregationDescriptor OtherBucketKey(string? otherBucketKey) => Assign(otherBucketKey, (a, v) => a.OtherBucketKeyValue = v);
		public FiltersAggregationDescriptor Keyed(bool? keyed = true) => Assign(keyed, (a, v) => a.KeyedValue = v);
		public FiltersAggregationDescriptor Meta(Func<FluentDictionary<string?, object?>, FluentDictionary<string?, object?>> selector) => Assign(selector, (a, v) => a.MetaValue = v?.Invoke(new FluentDictionary<string?, object?>()));
		public FiltersAggregationDescriptor Name(string? name) => Assign(name, (a, v) => a.NameValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (FiltersValue is not null)
			{
				writer.WritePropertyName("filters");
				JsonSerializer.Serialize(writer, FiltersValue, options);
			}

			if (OtherBucketValue.HasValue)
			{
				writer.WritePropertyName("other_bucket");
				writer.WriteBooleanValue(OtherBucketValue.Value);
			}

			if (!string.IsNullOrEmpty(OtherBucketKeyValue))
			{
				writer.WritePropertyName("other_bucket_key");
				writer.WriteStringValue(OtherBucketKeyValue);
			}

			if (KeyedValue.HasValue)
			{
				writer.WritePropertyName("keyed");
				writer.WriteBooleanValue(KeyedValue.Value);
			}

			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			if (!string.IsNullOrEmpty(NameValue))
			{
				writer.WritePropertyName("name");
				writer.WriteStringValue(NameValue);
			}

			writer.WriteEndObject();
		}
	}
}