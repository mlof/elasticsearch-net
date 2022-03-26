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
namespace Elastic.Clients.Elasticsearch.IndexManagement.UpdateAliases
{
	public partial class RemoveIndexAction : IActionVariant
	{
		[JsonIgnore]
		string IndexManagement.UpdateAliases.IActionVariant.ActionVariantName => "remove_index";
		[JsonInclude]
		[JsonPropertyName("index")]
		public Elastic.Clients.Elasticsearch.IndexName? Index { get; set; }

		[JsonInclude]
		[JsonPropertyName("indices")]
		public Elastic.Clients.Elasticsearch.Indices? Indices { get; set; }

		[JsonInclude]
		[JsonPropertyName("must_exist")]
		public bool? MustExist { get; set; }
	}

	public sealed partial class RemoveIndexActionDescriptor : DescriptorBase<RemoveIndexActionDescriptor>
	{
		internal RemoveIndexActionDescriptor(Action<RemoveIndexActionDescriptor> configure) => configure.Invoke(this);
		public RemoveIndexActionDescriptor() : base()
		{
		}

		private Elastic.Clients.Elasticsearch.IndexName? IndexValue { get; set; }

		private Elastic.Clients.Elasticsearch.Indices? IndicesValue { get; set; }

		private bool? MustExistValue { get; set; }

		public RemoveIndexActionDescriptor Index(Elastic.Clients.Elasticsearch.IndexName? index)
		{
			IndexValue = index;
			return Self;
		}

		public RemoveIndexActionDescriptor Indices(Elastic.Clients.Elasticsearch.Indices? indices)
		{
			IndicesValue = indices;
			return Self;
		}

		public RemoveIndexActionDescriptor MustExist(bool? mustExist = true)
		{
			MustExistValue = mustExist;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (IndexValue is not null)
			{
				writer.WritePropertyName("index");
				JsonSerializer.Serialize(writer, IndexValue, options);
			}

			if (IndicesValue is not null)
			{
				writer.WritePropertyName("indices");
				JsonSerializer.Serialize(writer, IndicesValue, options);
			}

			if (MustExistValue.HasValue)
			{
				writer.WritePropertyName("must_exist");
				writer.WriteBooleanValue(MustExistValue.Value);
			}

			writer.WriteEndObject();
		}
	}
}