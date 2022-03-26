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
	internal sealed class InferenceAggregationConverter : JsonConverter<InferenceAggregation>
	{
		public override InferenceAggregation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.StartObject)
				throw new JsonException("Unexpected JSON detected.");
			reader.Read();
			var aggName = reader.GetString();
			if (aggName != "inference")
				throw new JsonException("Unexpected JSON detected.");
			var agg = new InferenceAggregation(aggName);
			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("inference_config"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.InferenceConfigContainer?>(ref reader, options);
						if (value is not null)
						{
							agg.InferenceConfig = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("model_id"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Name>(ref reader, options);
						if (value is not null)
						{
							agg.ModelId = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("format"))
					{
						var value = JsonSerializer.Deserialize<string?>(ref reader, options);
						if (value is not null)
						{
							agg.Format = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("gap_policy"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.GapPolicy?>(ref reader, options);
						if (value is not null)
						{
							agg.GapPolicy = value;
						}

						continue;
					}

					if (reader.ValueTextEquals("buckets_path"))
					{
						var value = JsonSerializer.Deserialize<Elastic.Clients.Elasticsearch.Aggregations.BucketsPath?>(ref reader, options);
						if (value is not null)
						{
							agg.BucketsPath = value;
						}

						continue;
					}
				}
			}

			while (reader.Read() && reader.TokenType != JsonTokenType.EndObject)
			{
				if (reader.TokenType == JsonTokenType.PropertyName)
				{
					if (reader.ValueTextEquals("meta"))
					{
						var value = JsonSerializer.Deserialize<Dictionary<string, object>>(ref reader, options);
						if (value is not null)
						{
							agg.Meta = value;
						}

						continue;
					}
				}
			}

			reader.Read();
			return agg;
		}

		public override void Write(Utf8JsonWriter writer, InferenceAggregation value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("inference");
			writer.WriteStartObject();
			if (value.InferenceConfig is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, value.InferenceConfig, options);
			}

			writer.WritePropertyName("model_id");
			JsonSerializer.Serialize(writer, value.ModelId, options);
			if (!string.IsNullOrEmpty(value.Format))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(value.Format);
			}

			if (value.GapPolicy is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, value.GapPolicy, options);
			}

			if (value.BucketsPath is not null)
			{
				writer.WritePropertyName("buckets_path");
				JsonSerializer.Serialize(writer, value.BucketsPath, options);
			}

			writer.WriteEndObject();
			if (value.Meta is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, value.Meta, options);
			}

			writer.WriteEndObject();
		}
	}

	[JsonConverter(typeof(InferenceAggregationConverter))]
	public partial class InferenceAggregation : Aggregations.PipelineAggregationBase
	{
		public InferenceAggregation(string name) : base(name)
		{
		}

		[JsonInclude]
		[JsonPropertyName("inference_config")]
		public Elastic.Clients.Elasticsearch.Aggregations.InferenceConfigContainer? InferenceConfig { get; set; }

		[JsonInclude]
		[JsonPropertyName("model_id")]
		public Elastic.Clients.Elasticsearch.Name ModelId { get; set; }
	}

	public sealed partial class InferenceAggregationDescriptor<TDocument> : DescriptorBase<InferenceAggregationDescriptor<TDocument>>
	{
		internal InferenceAggregationDescriptor(Action<InferenceAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);
		public InferenceAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.InferenceConfigContainer? InferenceConfigValue { get; set; }

		private InferenceConfigContainerDescriptor<TDocument> InferenceConfigDescriptor { get; set; }

		private Action<InferenceConfigContainerDescriptor<TDocument>> InferenceConfigDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; set; }

		private string? FormatValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Elastic.Clients.Elasticsearch.Name ModelIdValue { get; set; }

		public InferenceAggregationDescriptor<TDocument> InferenceConfig(Elastic.Clients.Elasticsearch.Aggregations.InferenceConfigContainer? inferenceConfig)
		{
			InferenceConfigDescriptor = null;
			InferenceConfigDescriptorAction = null;
			InferenceConfigValue = inferenceConfig;
			return Self;
		}

		public InferenceAggregationDescriptor<TDocument> InferenceConfig(Aggregations.InferenceConfigContainerDescriptor<TDocument> descriptor)
		{
			InferenceConfigValue = null;
			InferenceConfigDescriptorAction = null;
			InferenceConfigDescriptor = descriptor;
			return Self;
		}

		public InferenceAggregationDescriptor<TDocument> InferenceConfig(Action<Aggregations.InferenceConfigContainerDescriptor<TDocument>> configure)
		{
			InferenceConfigValue = null;
			InferenceConfigDescriptorAction = null;
			InferenceConfigDescriptorAction = configure;
			return Self;
		}

		public InferenceAggregationDescriptor<TDocument> BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath)
		{
			BucketsPathValue = bucketsPath;
			return Self;
		}

		public InferenceAggregationDescriptor<TDocument> Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public InferenceAggregationDescriptor<TDocument> GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy)
		{
			GapPolicyValue = gapPolicy;
			return Self;
		}

		public InferenceAggregationDescriptor<TDocument> Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public InferenceAggregationDescriptor<TDocument> ModelId(Elastic.Clients.Elasticsearch.Name modelId)
		{
			ModelIdValue = modelId;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("inference");
			writer.WriteStartObject();
			if (InferenceConfigDescriptor is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, InferenceConfigDescriptor, options);
			}
			else if (InferenceConfigDescriptorAction is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, new Aggregations.InferenceConfigContainerDescriptor<TDocument>(InferenceConfigDescriptorAction), options);
			}
			else if (InferenceConfigValue is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, InferenceConfigValue, options);
			}

			if (BucketsPathValue is not null)
			{
				writer.WritePropertyName("buckets_path");
				JsonSerializer.Serialize(writer, BucketsPathValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (GapPolicyValue is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, GapPolicyValue, options);
			}

			writer.WritePropertyName("model_id");
			JsonSerializer.Serialize(writer, ModelIdValue, options);
			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class InferenceAggregationDescriptor : DescriptorBase<InferenceAggregationDescriptor>
	{
		internal InferenceAggregationDescriptor(Action<InferenceAggregationDescriptor> configure) => configure.Invoke(this);
		public InferenceAggregationDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.Aggregations.InferenceConfigContainer? InferenceConfigValue { get; set; }

		private InferenceConfigContainerDescriptor InferenceConfigDescriptor { get; set; }

		private Action<InferenceConfigContainerDescriptor> InferenceConfigDescriptorAction { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? BucketsPathValue { get; set; }

		private string? FormatValue { get; set; }

		private Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? GapPolicyValue { get; set; }

		private Dictionary<string, object>? MetaValue { get; set; }

		private Elastic.Clients.Elasticsearch.Name ModelIdValue { get; set; }

		public InferenceAggregationDescriptor InferenceConfig(Elastic.Clients.Elasticsearch.Aggregations.InferenceConfigContainer? inferenceConfig)
		{
			InferenceConfigDescriptor = null;
			InferenceConfigDescriptorAction = null;
			InferenceConfigValue = inferenceConfig;
			return Self;
		}

		public InferenceAggregationDescriptor InferenceConfig(Aggregations.InferenceConfigContainerDescriptor descriptor)
		{
			InferenceConfigValue = null;
			InferenceConfigDescriptorAction = null;
			InferenceConfigDescriptor = descriptor;
			return Self;
		}

		public InferenceAggregationDescriptor InferenceConfig(Action<Aggregations.InferenceConfigContainerDescriptor> configure)
		{
			InferenceConfigValue = null;
			InferenceConfigDescriptorAction = null;
			InferenceConfigDescriptorAction = configure;
			return Self;
		}

		public InferenceAggregationDescriptor BucketsPath(Elastic.Clients.Elasticsearch.Aggregations.BucketsPath? bucketsPath)
		{
			BucketsPathValue = bucketsPath;
			return Self;
		}

		public InferenceAggregationDescriptor Format(string? format)
		{
			FormatValue = format;
			return Self;
		}

		public InferenceAggregationDescriptor GapPolicy(Elastic.Clients.Elasticsearch.Aggregations.GapPolicy? gapPolicy)
		{
			GapPolicyValue = gapPolicy;
			return Self;
		}

		public InferenceAggregationDescriptor Meta(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
		{
			MetaValue = selector?.Invoke(new FluentDictionary<string, object>());
			return Self;
		}

		public InferenceAggregationDescriptor ModelId(Elastic.Clients.Elasticsearch.Name modelId)
		{
			ModelIdValue = modelId;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("inference");
			writer.WriteStartObject();
			if (InferenceConfigDescriptor is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, InferenceConfigDescriptor, options);
			}
			else if (InferenceConfigDescriptorAction is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, new Aggregations.InferenceConfigContainerDescriptor(InferenceConfigDescriptorAction), options);
			}
			else if (InferenceConfigValue is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, InferenceConfigValue, options);
			}

			if (BucketsPathValue is not null)
			{
				writer.WritePropertyName("buckets_path");
				JsonSerializer.Serialize(writer, BucketsPathValue, options);
			}

			if (!string.IsNullOrEmpty(FormatValue))
			{
				writer.WritePropertyName("format");
				writer.WriteStringValue(FormatValue);
			}

			if (GapPolicyValue is not null)
			{
				writer.WritePropertyName("gap_policy");
				JsonSerializer.Serialize(writer, GapPolicyValue, options);
			}

			writer.WritePropertyName("model_id");
			JsonSerializer.Serialize(writer, ModelIdValue, options);
			writer.WriteEndObject();
			if (MetaValue is not null)
			{
				writer.WritePropertyName("meta");
				JsonSerializer.Serialize(writer, MetaValue, options);
			}

			writer.WriteEndObject();
		}
	}
}