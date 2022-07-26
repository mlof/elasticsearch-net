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
namespace Elastic.Clients.Elasticsearch
{
	public sealed partial class FieldSort : ISortOptionsVariant
	{
		[JsonInclude]
		[JsonPropertyName("format")]
		public string? Format { get; init; }

		[JsonInclude]
		[JsonPropertyName("mode")]
		public Elastic.Clients.Elasticsearch.SortMode? Mode { get; init; }

		[JsonInclude]
		[JsonPropertyName("nested")]
		public Elastic.Clients.Elasticsearch.NestedSortValue? Nested { get; init; }

		[JsonInclude]
		[JsonPropertyName("numeric_type")]
		public Elastic.Clients.Elasticsearch.FieldSortNumericType? NumericType { get; init; }

		[JsonInclude]
		[JsonPropertyName("order")]
		public Elastic.Clients.Elasticsearch.SortOrder? Order { get; init; }

		[JsonInclude]
		[JsonPropertyName("unmapped_type")]
		public Elastic.Clients.Elasticsearch.Mapping.FieldType? UnmappedType { get; init; }
	}
}