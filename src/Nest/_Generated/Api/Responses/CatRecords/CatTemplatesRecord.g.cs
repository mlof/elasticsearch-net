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
// ------------------------------------------------

using System;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest
{
	public class CatTemplatesRecord
	{
		[JsonInclude, JsonPropertyName("c")]
		private string? _c = default;
		[JsonInclude, JsonPropertyName("composed_of")]
		private string? _composed_of = default;
		[JsonInclude, JsonPropertyName("index_patterns")]
		private string? _index_patterns = default;
		[JsonInclude, JsonPropertyName("n")]
		private Name? _n = default;
		[JsonInclude, JsonPropertyName("name")]
		private Name? _name = default;
		[JsonInclude, JsonPropertyName("o")]
		private string? _o = default;
		[JsonInclude, JsonPropertyName("order")]
		private string? _order = default;
		[JsonInclude, JsonPropertyName("p")]
		private string? _p = default;
		[JsonInclude, JsonPropertyName("t")]
		private string? _t = default;
		[JsonInclude, JsonPropertyName("v")]
		private VersionString? _v = default;
		[JsonInclude, JsonPropertyName("version")]
		private VersionString? _version = default;
		public string? ComposedOf => _c ?? _composed_of;
		public string? IndexPatterns => _t ?? _index_patterns;
		public Name? Name => _n ?? _name;
		public string? Order => _order ?? _o ?? _p;
		public VersionString? Version => _v ?? _version;
	}
}