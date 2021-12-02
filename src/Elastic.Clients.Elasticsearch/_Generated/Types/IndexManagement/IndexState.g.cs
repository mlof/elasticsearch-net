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
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public partial class IndexState
	{
		[JsonInclude]
		[JsonPropertyName("aliases")]
		public Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? Aliases { get; set; }

		[JsonInclude]
		[JsonPropertyName("mappings")]
		public Elastic.Clients.Elasticsearch.Mapping.TypeMapping? Mappings { get; set; }

		[JsonInclude]
		[JsonPropertyName("settings")]
		public Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? Settings { get; set; }

		[JsonInclude]
		[JsonPropertyName("defaults")]
		public Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? Defaults { get; set; }

		[JsonInclude]
		[JsonPropertyName("data_stream")]
		public Elastic.Clients.Elasticsearch.DataStreamName? DataStream { get; set; }
	}

	public sealed partial class IndexStateDescriptor<T> : DescriptorBase<IndexStateDescriptor<T>>
	{
		public IndexStateDescriptor()
		{
		}

		internal IndexStateDescriptor(Action<IndexStateDescriptor<T>> configure) => configure.Invoke(this);
		internal Dictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>? AliasesValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.Mapping.TypeMapping? MappingsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? SettingsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? DefaultsValue { get; private set; }

		internal Elastic.Clients.Elasticsearch.DataStreamName? DataStreamValue { get; private set; }

		internal Mapping.TypeMappingDescriptor MappingsDescriptor { get; private set; }

		internal IndexSettingsDescriptor<T> SettingsDescriptor { get; private set; }

		internal IndexSettingsDescriptor<T> DefaultsDescriptor { get; private set; }

		internal Action<Mapping.TypeMappingDescriptor> MappingsDescriptorAction { get; private set; }

		internal Action<IndexSettingsDescriptor<T>> SettingsDescriptorAction { get; private set; }

		internal Action<IndexSettingsDescriptor<T>> DefaultsDescriptorAction { get; private set; }

		public IndexStateDescriptor<T> Aliases(Func<FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>, FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>> selector) => Assign(selector, (a, v) => a.AliasesValue = v?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.IndexName, Elastic.Clients.Elasticsearch.IndexManagement.Alias>()));
		public IndexStateDescriptor<T> Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMapping? mappings)
		{
			MappingsDescriptor = null;
			MappingsDescriptorAction = null;
			return Assign(mappings, (a, v) => a.MappingsValue = v);
		}

		public IndexStateDescriptor<T> Mappings(Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor descriptor)
		{
			MappingsValue = null;
			MappingsDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.MappingsDescriptor = v);
		}

		public IndexStateDescriptor<T> Mappings(Action<Elastic.Clients.Elasticsearch.Mapping.TypeMappingDescriptor> configure)
		{
			MappingsValue = null;
			MappingsDescriptorAction = null;
			return Assign(configure, (a, v) => a.MappingsDescriptorAction = v);
		}

		public IndexStateDescriptor<T> Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? settings)
		{
			SettingsDescriptor = null;
			SettingsDescriptorAction = null;
			return Assign(settings, (a, v) => a.SettingsValue = v);
		}

		public IndexStateDescriptor<T> Settings(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor<T> descriptor)
		{
			SettingsValue = null;
			SettingsDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.SettingsDescriptor = v);
		}

		public IndexStateDescriptor<T> Settings(Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor<T>> configure)
		{
			SettingsValue = null;
			SettingsDescriptorAction = null;
			return Assign(configure, (a, v) => a.SettingsDescriptorAction = v);
		}

		public IndexStateDescriptor<T> Defaults(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettings? defaults)
		{
			DefaultsDescriptor = null;
			DefaultsDescriptorAction = null;
			return Assign(defaults, (a, v) => a.DefaultsValue = v);
		}

		public IndexStateDescriptor<T> Defaults(Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor<T> descriptor)
		{
			DefaultsValue = null;
			DefaultsDescriptorAction = null;
			return Assign(descriptor, (a, v) => a.DefaultsDescriptor = v);
		}

		public IndexStateDescriptor<T> Defaults(Action<Elastic.Clients.Elasticsearch.IndexManagement.IndexSettingsDescriptor<T>> configure)
		{
			DefaultsValue = null;
			DefaultsDescriptorAction = null;
			return Assign(configure, (a, v) => a.DefaultsDescriptorAction = v);
		}

		public IndexStateDescriptor<T> DataStream(Elastic.Clients.Elasticsearch.DataStreamName? dataStream) => Assign(dataStream, (a, v) => a.DataStreamValue = v);
		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (AliasesValue is not null)
			{
				writer.WritePropertyName("aliases");
				JsonSerializer.Serialize(writer, AliasesValue, options);
			}

			if (MappingsDescriptor is not null)
			{
				writer.WritePropertyName("mappings");
				JsonSerializer.Serialize(writer, MappingsDescriptor, options);
			}
			else if (MappingsDescriptorAction is not null)
			{
				writer.WritePropertyName("mappings");
				JsonSerializer.Serialize(writer, new Mapping.TypeMappingDescriptor(MappingsDescriptorAction), options);
			}
			else if (MappingsValue is not null)
			{
				writer.WritePropertyName("mappings");
				JsonSerializer.Serialize(writer, MappingsValue, options);
			}

			if (SettingsDescriptor is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsDescriptor, options);
			}
			else if (SettingsDescriptorAction is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, new IndexSettingsDescriptor<T>(SettingsDescriptorAction), options);
			}
			else if (SettingsValue is not null)
			{
				writer.WritePropertyName("settings");
				JsonSerializer.Serialize(writer, SettingsValue, options);
			}

			if (DefaultsDescriptor is not null)
			{
				writer.WritePropertyName("defaults");
				JsonSerializer.Serialize(writer, DefaultsDescriptor, options);
			}
			else if (DefaultsDescriptorAction is not null)
			{
				writer.WritePropertyName("defaults");
				JsonSerializer.Serialize(writer, new IndexSettingsDescriptor<T>(DefaultsDescriptorAction), options);
			}
			else if (DefaultsValue is not null)
			{
				writer.WritePropertyName("defaults");
				JsonSerializer.Serialize(writer, DefaultsValue, options);
			}

			if (DataStreamValue is not null)
			{
				writer.WritePropertyName("data_stream");
				JsonSerializer.Serialize(writer, DataStreamValue, options);
			}

			writer.WriteEndObject();
		}
	}
}