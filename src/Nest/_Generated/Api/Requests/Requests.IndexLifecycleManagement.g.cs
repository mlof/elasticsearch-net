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
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Nest.Ilm
{
	[ConvertAs(typeof(DeleteLifecycleRequest))]
	public partial interface IDeleteLifecycleRequest : IRequest<DeleteLifecycleRequestParameters>
	{
	}

	public partial class DeleteLifecycleRequest : PlainRequestBase<DeleteLifecycleRequestParameters>, IDeleteLifecycleRequest
	{
		protected IDeleteLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementDeleteLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_ilm/policy/{policy}</summary>
        public DeleteLifecycleRequest(Nest.Name? policy) : base(r => r.Optional("policy", policy))
		{
		}
	}

	[ConvertAs(typeof(ExplainLifecycleRequest))]
	public partial interface IExplainLifecycleRequest : IRequest<ExplainLifecycleRequestParameters>
	{
	}

	public partial class ExplainLifecycleRequest : PlainRequestBase<ExplainLifecycleRequestParameters>, IExplainLifecycleRequest
	{
		protected IExplainLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementExplainLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/{index}/_ilm/explain</summary>
        public ExplainLifecycleRequest(Nest.IndexName index) : base(r => r.Required("index", index))
		{
		}

		[JsonIgnore]
		public bool? OnlyErrors { get => Q<bool?>("only_errors"); set => Q("only_errors", value); }

		[JsonIgnore]
		public bool? OnlyManaged { get => Q<bool?>("only_managed"); set => Q("only_managed", value); }
	}

	[ConvertAs(typeof(GetLifecycleRequest))]
	public partial interface IGetLifecycleRequest : IRequest<GetLifecycleRequestParameters>
	{
	}

	public partial class GetLifecycleRequest : PlainRequestBase<GetLifecycleRequestParameters>, IGetLifecycleRequest
	{
		protected IGetLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementGetLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_ilm/policy/{policy}</summary>
        public GetLifecycleRequest(Nest.Name? policy) : base(r => r.Optional("policy", policy))
		{
		}

		///<summary>/_ilm/policy</summary>
        public GetLifecycleRequest() : base()
		{
		}
	}

	[ConvertAs(typeof(GetStatusRequest))]
	public partial interface IGetStatusRequest : IRequest<GetStatusRequestParameters>
	{
	}

	public partial class GetStatusRequest : PlainRequestBase<GetStatusRequestParameters>, IGetStatusRequest
	{
		protected IGetStatusRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementGetStatus;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_ilm/status</summary>
        public GetStatusRequest() : base()
		{
		}
	}

	[ConvertAs(typeof(MoveToStepRequest))]
	public partial interface IMoveToStepRequest : IRequest<MoveToStepRequestParameters>
	{
	}

	public partial class MoveToStepRequest : PlainRequestBase<MoveToStepRequestParameters>, IMoveToStepRequest
	{
		protected IMoveToStepRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementMoveToStep;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_ilm/move/{index}</summary>
        public MoveToStepRequest(Nest.IndexName index) : base(r => r.Required("index", index))
		{
		}

		[JsonPropertyName("current_step")]
		public Nest.Ilm.MoveToStep.StepKey? CurrentStep
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("next_step")]
		public Nest.Ilm.MoveToStep.StepKey? NextStep
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	[ConvertAs(typeof(PutLifecycleRequest))]
	public partial interface IPutLifecycleRequest : IRequest<PutLifecycleRequestParameters>
	{
	}

	public partial class PutLifecycleRequest : PlainRequestBase<PutLifecycleRequestParameters>, IPutLifecycleRequest
	{
		protected IPutLifecycleRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementPutLifecycle;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;

		///<summary>/_ilm/policy/{policy}</summary>
        public PutLifecycleRequest(Nest.Name? policy) : base(r => r.Optional("policy", policy))
		{
		}
	}

	[ConvertAs(typeof(RemovePolicyRequest))]
	public partial interface IRemovePolicyRequest : IRequest<RemovePolicyRequestParameters>
	{
	}

	public partial class RemovePolicyRequest : PlainRequestBase<RemovePolicyRequestParameters>, IRemovePolicyRequest
	{
		protected IRemovePolicyRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRemovePolicy;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/{index}/_ilm/remove</summary>
        public RemovePolicyRequest(Nest.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	[ConvertAs(typeof(RetryRequest))]
	public partial interface IRetryRequest : IRequest<RetryRequestParameters>
	{
	}

	public partial class RetryRequest : PlainRequestBase<RetryRequestParameters>, IRetryRequest
	{
		protected IRetryRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementRetry;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/{index}/_ilm/retry</summary>
        public RetryRequest(Nest.IndexName index) : base(r => r.Required("index", index))
		{
		}
	}

	[ConvertAs(typeof(StartRequest))]
	public partial interface IStartRequest : IRequest<StartRequestParameters>
	{
	}

	public partial class StartRequest : PlainRequestBase<StartRequestParameters>, IStartRequest
	{
		protected IStartRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementStart;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_ilm/start</summary>
        public StartRequest() : base()
		{
		}

		[JsonPropertyName("stub")]
		public bool Stub
		{
			get;
#if NET5_0
			init;
#else
			internal set;
#endif
		}
	}

	[ConvertAs(typeof(StopRequest))]
	public partial interface IStopRequest : IRequest<StopRequestParameters>
	{
	}

	public partial class StopRequest : PlainRequestBase<StopRequestParameters>, IStopRequest
	{
		protected IStopRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.IndexLifecycleManagementStop;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => false;
		protected override bool IsEmpty => false;

		///<summary>/_ilm/stop</summary>
        public StopRequest() : base()
		{
		}

		[JsonPropertyName("stub")]
		public bool Stub
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