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
namespace Elastic.Clients.Elasticsearch.Nodes
{
	public partial class SerializedClusterStateDetail
	{
		[JsonInclude]
		[JsonPropertyName("compressed_size")]
		public string? CompressedSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("compressed_size_in_bytes")]
		public long? CompressedSizeInBytes { get; init; }

		[JsonInclude]
		[JsonPropertyName("count")]
		public long? Count { get; init; }

		[JsonInclude]
		[JsonPropertyName("uncompressed_size")]
		public string? UncompressedSize { get; init; }

		[JsonInclude]
		[JsonPropertyName("uncompressed_size_in_bytes")]
		public long? UncompressedSizeInBytes { get; init; }
	}
}