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
using Elastic.Transport;

#nullable restore
namespace Nest
{
	[JsonInterfaceConverter(typeof(InterfaceConverter<IDeleteAutoscalingPolicyRequest, DeleteAutoscalingPolicyRequest>))]
	public interface IDeleteAutoscalingPolicyRequest : IRequest<DeleteAutoscalingPolicyRequestParameters>
	{
	}

	public class DeleteAutoscalingPolicyRequest : PlainRequestBase<DeleteAutoscalingPolicyRequestParameters>, IDeleteAutoscalingPolicyRequest
	{
		protected IDeleteAutoscalingPolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingDeleteAutoscalingPolicy;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;
		///<summary>/_autoscaling/policy/{name}</summary>
        public DeleteAutoscalingPolicyRequest(Name name) : base(r => r)
		{
		}

		[JsonIgnore]
		public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }

		[JsonPropertyName("stub_c")]
		public string StubC
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IGetAutoscalingCapacityRequest, GetAutoscalingCapacityRequest>))]
	public interface IGetAutoscalingCapacityRequest : IRequest<GetAutoscalingCapacityRequestParameters>
	{
	}

	public class GetAutoscalingCapacityRequest : PlainRequestBase<GetAutoscalingCapacityRequestParameters>, IGetAutoscalingCapacityRequest
	{
		protected IGetAutoscalingCapacityRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingGetAutoscalingCapacity;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;
		///<summary>/_autoscaling/capacity</summary>
        public GetAutoscalingCapacityRequest() : base()
		{
		}

		[JsonIgnore]
		public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }

		[JsonPropertyName("stub_c")]
		public string StubC
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IGetAutoscalingPolicyRequest, GetAutoscalingPolicyRequest>))]
	public interface IGetAutoscalingPolicyRequest : IRequest<GetAutoscalingPolicyRequestParameters>
	{
	}

	public class GetAutoscalingPolicyRequest : PlainRequestBase<GetAutoscalingPolicyRequestParameters>, IGetAutoscalingPolicyRequest
	{
		protected IGetAutoscalingPolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingGetAutoscalingPolicy;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;
		///<summary>/_autoscaling/policy/{name}</summary>
        public GetAutoscalingPolicyRequest(Name name) : base(r => r)
		{
		}

		[JsonIgnore]
		public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }

		[JsonPropertyName("stub_c")]
		public string StubC
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IPutAutoscalingPolicyRequest, PutAutoscalingPolicyRequest>))]
	public interface IPutAutoscalingPolicyRequest : IRequest<PutAutoscalingPolicyRequestParameters>
	{
	}

	public class PutAutoscalingPolicyRequest : PlainRequestBase<PutAutoscalingPolicyRequestParameters>, IPutAutoscalingPolicyRequest
	{
		protected IPutAutoscalingPolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.AutoscalingPutAutoscalingPolicy;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;
		///<summary>/_autoscaling/policy/{name}</summary>
        public PutAutoscalingPolicyRequest(Name name) : base(r => r)
		{
		}

		[JsonIgnore]
		public string StubB { get => Q<string>("stub_b"); set => Q("stub_b", value); }

		[JsonPropertyName("stub_c")]
		public string StubC
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}
}