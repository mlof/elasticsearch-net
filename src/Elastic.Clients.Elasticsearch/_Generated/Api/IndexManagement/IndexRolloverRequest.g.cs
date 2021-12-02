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
	public class IndexRolloverRequestParameters : RequestParameters<IndexRolloverRequestParameters>
	{
		[JsonIgnore]
		public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

		[JsonIgnore]
		public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }
	}

	public partial class IndexRolloverRequest : PlainRequestBase<IndexRolloverRequestParameters>
	{
		public IndexRolloverRequest(Elastic.Clients.Elasticsearch.IndexAlias alias) : base(r => r.Required("alias", alias))
		{
		}

		public IndexRolloverRequest(Elastic.Clients.Elasticsearch.IndexAlias alias, Elastic.Clients.Elasticsearch.IndexName? new_index) : base(r => r.Required("alias", alias).Optional("new_index", new_index))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementRollover;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		[JsonIgnore]
		public bool? DryRun { get => Q<bool?>("dry_run"); set => Q("dry_run", value); }

		[JsonIgnore]
		public bool? IncludeTypeName { get => Q<bool?>("include_type_name"); set => Q("include_type_name", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("master_timeout"); set => Q("master_timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.Time? Timeout { get => Q<Elastic.Clients.Elasticsearch.Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public Elastic.Clients.Elasticsearch.WaitForActiveShards? WaitForActiveShards { get => Q<Elastic.Clients.Elasticsearch.WaitForActiveShards?>("wait_for_active_shards"); set => Q("wait_for_active_shards", value); }

		[JsonInclude]
		[JsonPropertyName("aliases")]
		public Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? Aliases { get; set; }

		[JsonInclude]
		[JsonPropertyName("conditions")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Rollover.RolloverConditions? Conditions { get; set; }

		[JsonInclude]
		[JsonPropertyName("mappings")]
		public Elastic.Clients.Elasticsearch.IndexManagement.Rollover.IndexRolloverMapping? Mappings { get; set; }

		[JsonInclude]
		[JsonPropertyName("settings")]
		public Dictionary<string, object>? Settings { get; set; }
	}

	public sealed partial class IndexRolloverRequestDescriptor : RequestDescriptorBase<IndexRolloverRequestDescriptor, IndexRolloverRequestParameters>
	{
		public IndexRolloverRequestDescriptor(Elastic.Clients.Elasticsearch.IndexAlias alias) : base(r => r.Required("alias", alias))
		{
		}

		public IndexRolloverRequestDescriptor(Elastic.Clients.Elasticsearch.IndexAlias alias, Elastic.Clients.Elasticsearch.IndexName? new_index) : base(r => r.Required("alias", alias).Optional("new_index", new_index))
		{
		}

		public IndexRolloverRequestDescriptor()
		{
		}

		internal IndexRolloverRequestDescriptor(Action<IndexRolloverRequestDescriptor> configure) => configure.Invoke(this);
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementRollover;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		public IndexRolloverRequestDescriptor DryRun(bool? dryRun) => Qs("dry_run", dryRun);
		public IndexRolloverRequestDescriptor IncludeTypeName(bool? includeTypeName) => Qs("include_type_name", includeTypeName);
		public IndexRolloverRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Time? masterTimeout) => Qs("master_timeout", masterTimeout);
		public IndexRolloverRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Time? timeout) => Qs("timeout", timeout);
		public IndexRolloverRequestDescriptor WaitForActiveShards(Elastic.Clients.Elasticsearch.WaitForActiveShards? waitForActiveShards) => Qs("wait_for_active_shards", waitForActiveShards);
		internal Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? AliasesValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.IndexManagement.Rollover.RolloverConditions? ConditionsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.IndexManagement.Rollover.IndexRolloverMapping? MappingsValue { get; private set; }

		internal Dictionary<string, object>? SettingsValue { get; private set; }

		internal IndexManagement.Rollover.RolloverConditionsDescriptor ConditionsDescriptor { get; private set; }

		internal Action<IndexManagement.Rollover.RolloverConditionsDescriptor> ConditionsDescriptorAction { get; private set; }

		public IndexRolloverRequestDescriptor Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>, FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>> selector) => Assign(selector, (a, v) => a.AliasesValue = v?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>()));
		public IndexRolloverRequestDescriptor Conditions(Elastic.Clients.Elasticsearch.IndexManagement.Rollover.RolloverConditions? conditions)
		{
			ConditionsDescriptor = null;
			ConditionsDescriptorAction = null;
			return Assign(conditions, (a, v) => a.ConditionsValue = v);
		}

		public IndexRolloverRequestDescriptor Conditions(Elastic.Clients.Elasticsearch.IndexManagement.Rollover.RolloverConditionsDescriptor descriptor)
		{
			ConditionsValue = null;
			ConditionsDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.ConditionsDescriptor = v);
		}

		public IndexRolloverRequestDescriptor Conditions(Action<Elastic.Clients.Elasticsearch.IndexManagement.Rollover.RolloverConditionsDescriptor> configure)
		{
			ConditionsValue = null;
			ConditionsDescriptorAction = null;
			return Assign(configure, (a, v) => a.ConditionsDescriptorAction = v);
		}

		public IndexRolloverRequestDescriptor Mappings(Elastic.Clients.Elasticsearch.IndexManagement.Rollover.IndexRolloverMapping? mappings) => Assign(mappings, (a, v) => a.MappingsValue = v);
		public IndexRolloverRequestDescriptor Settings(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector) => Assign(selector, (a, v) => a.SettingsValue = v?.Invoke(new FluentDictionary<string, object>()));
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AliasesValue is not null)
			{
				writer.WritePropertyName("aliases");
				JsonSerializer.Serialize(writer, AliasesValue, options);
			}

			if (ConditionsDescriptor is not null)
			{
				writer.WritePropertyName("conditions");
				JsonSerializer.Serialize(writer, ConditionsDescriptor, options);
			}
			else if (ConditionsDescriptorAction is not null)
			{
				writer.WritePropertyName("conditions");
				JsonSerializer.Serialize(writer, new IndexManagement.Rollover.RolloverConditionsDescriptor(ConditionsDescriptorAction), options);
			}
			else if (ConditionsValue is not null)
			{
				writer.WritePropertyName("conditions");
				JsonSerializer.Serialize(writer, ConditionsValue, options);
			}

			if (MappingsValue is not null)
			{
				writer.WritePropertyName("mappings");
				JsonSerializer.Serialize(writer, MappingsValue, options);
			}

			if (SettingsValue is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsValue, options);
			}

			writer.WriteEndObject();
		}
	}
}