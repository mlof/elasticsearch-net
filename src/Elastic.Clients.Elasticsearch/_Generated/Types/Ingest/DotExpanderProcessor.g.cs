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
	public partial class DotExpanderProcessor : Ingest.ProcessorBase, IProcessorContainerVariant
	{
		[JsonIgnore]
		string Ingest.IProcessorContainerVariant.ProcessorContainerVariantName => "dot_expander";
		[JsonInclude]
		[JsonPropertyName("field")]
		public Elastic.Clients.Elasticsearch.Field Field { get; set; }

		[JsonInclude]
		[JsonPropertyName("path")]
		public string? Path { get; set; }
	}

	public sealed partial class DotExpanderProcessorDescriptor<T> : DescriptorBase<DotExpanderProcessorDescriptor<T>>
	{
		public DotExpanderProcessorDescriptor()
		{
		}

		internal DotExpanderProcessorDescriptor(Action<DotExpanderProcessorDescriptor<T>> configure) => configure.Invoke(this);
		internal Elastic.Clients.Elasticsearch.Field FieldValue { get; private set; }

		internal string? PathValue { get; private set; }

		internal string? IfValue { get; private set; }

		internal bool? IgnoreFailureValue { get; private set; }

		internal IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? OnFailureValue { get; private set; }

		internal string? TagValue { get; private set; }

		public DotExpanderProcessorDescriptor<T> Field(Elastic.Clients.Elasticsearch.Field field) => Assign(field, (a, v) => a.FieldValue = v);
		public DotExpanderProcessorDescriptor<T> Field<TValue>(Expression<Func<T, TValue>> field) => Assign(field, (a, v) => a.FieldValue = v);
		public DotExpanderProcessorDescriptor<T> Path(string? path) => Assign(path, (a, v) => a.PathValue = v);
		public DotExpanderProcessorDescriptor<T> If(string? ifValue) => Assign(ifValue, (a, v) => a.IfValue = v);
		public DotExpanderProcessorDescriptor<T> IgnoreFailure(bool? ignoreFailure = true) => Assign(ignoreFailure, (a, v) => a.IgnoreFailureValue = v);
		public DotExpanderProcessorDescriptor<T> OnFailure(IEnumerable<Elastic.Clients.Elasticsearch.Ingest.ProcessorContainer>? onFailure) => Assign(onFailure, (a, v) => a.OnFailureValue = v);
		public DotExpanderProcessorDescriptor<T> Tag(string? tag) => Assign(tag, (a, v) => a.TagValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
			if (!string.IsNullOrEmpty(PathValue))
			{
				writer.WritePropertyName("path");
				writer.WriteStringValue(PathValue);
			}

			writer.WriteEndObject();
		}
	}
}