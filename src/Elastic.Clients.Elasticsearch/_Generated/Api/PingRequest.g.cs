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
namespace Elastic.Clients.Elasticsearch
{
	public class PingRequestParameters : RequestParameters<PingRequestParameters>
	{
	}

	[InterfaceConverterAttribute(typeof(PingRequestDescriptorConverter<PingRequest>))]
	public partial interface IPingRequest : IRequest<PingRequestParameters>
	{
	}

	public partial class PingRequest : PlainRequestBase<PingRequestParameters>, IPingRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespacePing;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
	}

	public partial class PingRequestDescriptor : RequestDescriptorBase<PingRequestDescriptor, PingRequestParameters, IPingRequest>, IPingRequest
	{
		///<summary>/</summary>
        public PingRequestDescriptor() : base()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.NoNamespacePing;
		protected override HttpMethod HttpMethod => HttpMethod.HEAD;
		protected override bool SupportsBody => false;
	}

	internal sealed class PingRequestDescriptorConverter<TReadAs> : JsonConverter<IPingRequest> where TReadAs : class, IPingRequest
	{
		public override IPingRequest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => JsonSerializer.Deserialize<TReadAs>(ref reader, options);
		public override void Write(Utf8JsonWriter writer, IPingRequest value, JsonSerializerOptions options)
		{
			writer.WriteStartObject();
			writer.WriteEndObject();
		}
	}
}