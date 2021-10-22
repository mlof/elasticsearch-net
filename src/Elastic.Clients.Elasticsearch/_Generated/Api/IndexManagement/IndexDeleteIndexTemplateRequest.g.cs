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
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.IndexManagement
{
	public class IndexDeleteIndexTemplateRequestParameters : RequestParameters<IndexDeleteIndexTemplateRequestParameters>
	{
	}

	[InterfaceConverterAttribute(typeof(IndexDeleteIndexTemplateRequestDescriptorConverter<IndexDeleteIndexTemplateRequest>))]
	public partial interface IIndexDeleteIndexTemplateRequest : IRequest<IndexDeleteIndexTemplateRequestParameters>
	{
	}

	public partial class IndexDeleteIndexTemplateRequest : PlainRequestBase<IndexDeleteIndexTemplateRequestParameters>, IIndexDeleteIndexTemplateRequest
	{
		public IndexDeleteIndexTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDeleteIndexTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	public partial class IndexDeleteIndexTemplateRequestDescriptor : RequestDescriptorBase<IndexDeleteIndexTemplateRequestDescriptor, IndexDeleteIndexTemplateRequestParameters, IIndexDeleteIndexTemplateRequest>, IIndexDeleteIndexTemplateRequest
	{
		///<summary>/_index_template/{name}</summary>
        public IndexDeleteIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexManagementDeleteIndexTemplate;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
	}

	internal sealed class IndexDeleteIndexTemplateRequestDescriptorConverter<TReadAs> : JsonConverter<IIndexDeleteIndexTemplateRequest> where TReadAs : class, IIndexDeleteIndexTemplateRequest
	{
		public override IIndexDeleteIndexTemplateRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => JsonSerializer.Deserialize<TReadAs>(ref reader, options);
		public override void Write(Utf8JsonWriter writer, IIndexDeleteIndexTemplateRequest value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}