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
	[JsonInterfaceConverter(typeof(InterfaceConverter<ICancelTasksRequest, CancelTasksRequest>))]
	public interface ICancelTasksRequest : IRequest<CancelTasksRequestParameters>
	{
	}

	public class CancelTasksRequest : PlainRequestBase<CancelTasksRequestParameters>, ICancelTasksRequest
	{
		protected ICancelTasksRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksCancel;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_tasks/_cancel</summary>
        public CancelTasksRequest() : base()
		{
		}

		///<summary>/_tasks/{task_id}/_cancel</summary>
        public CancelTasksRequest(TaskId taskId) : base(r => r.Optional("task_id", taskId))
		{
		}

		[JsonIgnore]
		public string? ParentTaskId { get => Q<string?>("parent_task_id"); set => Q("parent_task_id", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IGetTaskRequest, GetTaskRequest>))]
	public interface IGetTaskRequest : IRequest<GetTaskRequestParameters>
	{
	}

	public class GetTaskRequest : PlainRequestBase<GetTaskRequestParameters>, IGetTaskRequest
	{
		protected IGetTaskRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksGet;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_tasks/{task_id}</summary>
        public GetTaskRequest(Id taskId) : base(r => r.Required("task_id", taskId))
		{
		}

		[JsonIgnore]
		public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IListTasksRequest, ListTasksRequest>))]
	public interface IListTasksRequest : IRequest<ListTasksRequestParameters>
	{
	}

	public class ListTasksRequest : PlainRequestBase<ListTasksRequestParameters>, IListTasksRequest
	{
		protected IListTasksRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TasksList;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_tasks</summary>
        public ListTasksRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }

		[JsonIgnore]
		public GroupBy? GroupBy { get => Q<GroupBy?>("group_by"); set => Q("group_by", value); }

		[JsonIgnore]
		public Id? ParentTaskId { get => Q<Id?>("parent_task_id"); set => Q("parent_task_id", value); }

		[JsonIgnore]
		public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}
}