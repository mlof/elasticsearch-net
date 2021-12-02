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
namespace Elastic.Clients.Elasticsearch.Ingest
{
	public partial class InferenceProcessor : Ingest.ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string Ingest.IProcessorContainerVariant.ProcessorContainerVariantName => "inference";
		[JsonInclude]
		[JsonPropertyName("model_id")]
		public Elastic.Clients.Elasticsearch.Id ModelId { get; set; }

		[JsonInclude]
		[JsonPropertyName("target_field")]
		public Elastic.Clients.Elasticsearch.Field TargetField { get; set; }

		[JsonInclude]
		[JsonPropertyName("field_map")]
		public Dictionary<Elastic.Clients.Elasticsearch.Field, object>? FieldMap { get; set; }

		[JsonInclude]
		[JsonPropertyName("inference_config")]
		public Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? InferenceConfig { get; set; }
	}

	public sealed partial class InferenceProcessorDescriptor<T> : DescriptorBase<InferenceProcessorDescriptor<T>>
	{
		public InferenceProcessorDescriptor()
		{
		}

		internal InferenceProcessorDescriptor(Action<InferenceProcessorDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Id ModelIdValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Field TargetFieldValue { get; private set; }

		internal Dictionary<Elastic.Clients.Elasticsearch.Field, object>? FieldMapValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? InferenceConfigValue { get; private set; }

		internal string? IfValue { get; private set; }

		internal bool? IgnoreFailureValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; private set; }

		internal string? TagValue { get; private set; }

		internal InferenceConfigDescriptor InferenceConfigDescriptor { get; private set; }

		internal Action<InferenceConfigDescriptor> InferenceConfigDescriptorAction { get; private set; }

		public InferenceProcessorDescriptor<T> ModelId(Elastic.Clients.Elasticsearch.Id modelId) => Assign(modelId, (a, v) => a.ModelIdValue = v);
		public InferenceProcessorDescriptor<T> TargetField(Elastic.Clients.Elasticsearch.Field targetField) => Assign(targetField, (a, v) => a.TargetFieldValue = v);
		public InferenceProcessorDescriptor<T> TargetField<TValue>(Expression<Func<T, TValue>> targetField) => Assign(targetField, (a, v) => a.TargetFieldValue = v);
		public InferenceProcessorDescriptor<T> FieldMap(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>> selector) => Assign(selector, (a, v) => a.FieldMapValue = v?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>()));
		public InferenceProcessorDescriptor<T> InferenceConfig(Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? inferenceConfig)
		{
			InferenceConfigDescriptor = null;
			InferenceConfigDescriptorAction = null;
			return Assign(inferenceConfig, (a, v) => a.InferenceConfigValue = v);
		}

		public InferenceProcessorDescriptor<T> InferenceConfig(Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor descriptor)
		{
			InferenceConfigValue = null;
			InferenceConfigDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.InferenceConfigDescriptor = v);
		}

		public InferenceProcessorDescriptor<T> InferenceConfig(Action<Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor> configure)
		{
			InferenceConfigValue = null;
			InferenceConfigDescriptorAction = null;
			return Assign(configure, (a, v) => a.InferenceConfigDescriptorAction = v);
		}

		public InferenceProcessorDescriptor<T> If(string? ifValue) => Assign(ifValue, (a, v) => a.IfValue = v);
		public InferenceProcessorDescriptor<T> IgnoreFailure(bool? ignoreFailure = true) => Assign(ignoreFailure, (a, v) => a.IgnoreFailureValue = v);
		public InferenceProcessorDescriptor<T> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure) => Assign(onFailure, (a, v) => a.OnFailureValue = v);
		public InferenceProcessorDescriptor<T> Tag(string? tag) => Assign(tag, (a, v) => a.TagValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("model_id");
			JsonSerializer.Serialize(writer, ModelIdValue, options);
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
			if (FieldMapValue is not null)
			{
				writer.WritePropertyName("field_map");
				JsonSerializer.Serialize(writer, FieldMapValue, options);
			}

			if (InferenceConfigDescriptor is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, InferenceConfigDescriptor, options);
			}
			else if (InferenceConfigDescriptorAction is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, new InferenceConfigDescriptor(InferenceConfigDescriptorAction), options);
			}
			else if (InferenceConfigValue is not null)
			{
				writer.WritePropertyName("inference_config");
				JsonSerializer.Serialize(writer, InferenceConfigValue, options);
			}

			writer.WriteEndObject();
		}
	}
}