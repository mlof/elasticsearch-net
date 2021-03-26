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
	public class CatTrainedModelsRecord
	{
		[JsonInclude, JsonPropertyName("c")]
		private string? _c = default;
		[JsonInclude, JsonPropertyName("create_time")]
		private DateTimeOffset? _create_time = default;
		[JsonInclude, JsonPropertyName("created_by")]
		private string? _created_by = default;
		[JsonInclude, JsonPropertyName("createdBy")]
		private string? _createdBy = default;
		[JsonInclude, JsonPropertyName("ct")]
		private DateTimeOffset? _ct = default;
		[JsonInclude, JsonPropertyName("d")]
		private string? _d = default;
		[JsonInclude, JsonPropertyName("data_frame.analysis")]
		private string? _data_frame_analysis = default;
		[JsonInclude, JsonPropertyName("data_frame.create_time")]
		private string? _data_frame_create_time = default;
		[JsonInclude, JsonPropertyName("data_frame.id")]
		private string? _data_frame_id = default;
		[JsonInclude, JsonPropertyName("data_frame.source_index")]
		private string? _data_frame_source_index = default;
		[JsonInclude, JsonPropertyName("dataFrameAnalytics")]
		private string? _dataFrameAnalytics = default;
		[JsonInclude, JsonPropertyName("dataFrameAnalyticsAnalysis")]
		private string? _dataFrameAnalyticsAnalysis = default;
		[JsonInclude, JsonPropertyName("dataFrameAnalyticsSrcIndex")]
		private string? _dataFrameAnalyticsSrcIndex = default;
		[JsonInclude, JsonPropertyName("dataFrameAnalyticsTime")]
		private string? _dataFrameAnalyticsTime = default;
		[JsonInclude, JsonPropertyName("description")]
		private string? _description = default;
		[JsonInclude, JsonPropertyName("dfa")]
		private string? _dfa = default;
		[JsonInclude, JsonPropertyName("dfid")]
		private string? _dfid = default;
		[JsonInclude, JsonPropertyName("dfsi")]
		private string? _dfsi = default;
		[JsonInclude, JsonPropertyName("dft")]
		private string? _dft = default;
		[JsonInclude, JsonPropertyName("heap_size")]
		private ByteSize? _heap_size = default;
		[JsonInclude, JsonPropertyName("hs")]
		private ByteSize? _hs = default;
		[JsonInclude, JsonPropertyName("ic")]
		private string? _ic = default;
		[JsonInclude, JsonPropertyName("icurr")]
		private string? _icurr = default;
		[JsonInclude, JsonPropertyName("if")]
		private string? _if = default;
		[JsonInclude, JsonPropertyName("ingest.count")]
		private string? _ingest_count = default;
		[JsonInclude, JsonPropertyName("ingest.current")]
		private string? _ingest_current = default;
		[JsonInclude, JsonPropertyName("ingest.failed")]
		private string? _ingest_failed = default;
		[JsonInclude, JsonPropertyName("ingest.pipelines")]
		private string? _ingest_pipelines = default;
		[JsonInclude, JsonPropertyName("ingest.time")]
		private string? _ingest_time = default;
		[JsonInclude, JsonPropertyName("ingestCount")]
		private string? _ingestCount = default;
		[JsonInclude, JsonPropertyName("ingestCurrent")]
		private string? _ingestCurrent = default;
		[JsonInclude, JsonPropertyName("ingestFailed")]
		private string? _ingestFailed = default;
		[JsonInclude, JsonPropertyName("ingestPipelines")]
		private string? _ingestPipelines = default;
		[JsonInclude, JsonPropertyName("ingestTime")]
		private string? _ingestTime = default;
		[JsonInclude, JsonPropertyName("ip")]
		private string? _ip = default;
		[JsonInclude, JsonPropertyName("it")]
		private string? _it = default;
		[JsonInclude, JsonPropertyName("l")]
		private string? _l = default;
		[JsonInclude, JsonPropertyName("license")]
		private string? _license = default;
		[JsonInclude, JsonPropertyName("modelHeapSize")]
		private ByteSize? _modelHeapSize = default;
		[JsonInclude, JsonPropertyName("modelOperations")]
		private string? _modelOperations = default;
		[JsonInclude, JsonPropertyName("o")]
		private string? _o = default;
		[JsonInclude, JsonPropertyName("operations")]
		private string? _operations = default;
		[JsonInclude, JsonPropertyName("v")]
		private VersionString? _v = default;
		[JsonInclude, JsonPropertyName("version")]
		private VersionString? _version = default;
		public string? CreatedBy => _created_by ?? _c ?? _createdBy;
		public DateTimeOffset? CreateTime => _ct ?? _create_time;
		public string? DataFrameAnalysis => _data_frame_analysis ?? _dfa ?? _dataFrameAnalyticsAnalysis;
		public string? DataFrameCreateTime => _data_frame_create_time ?? _dft ?? _dataFrameAnalyticsTime;
		public string? DataFrameId => _data_frame_id ?? _dfid ?? _dataFrameAnalytics;
		public string? DataFrameSourceIndex => _data_frame_source_index ?? _dfsi ?? _dataFrameAnalyticsSrcIndex;
		public string? Description => _d ?? _description;
		public ByteSize? HeapSize => _heap_size ?? _hs ?? _modelHeapSize;
		[JsonPropertyName("id")]
		public Id? Id
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? IngestCount => _ingest_count ?? _ic ?? _ingestCount;
		public string? IngestCurrent => _ingest_current ?? _icurr ?? _ingestCurrent;
		public string? IngestFailed => _ingest_failed ?? _if ?? _ingestFailed;
		public string? IngestPipelines => _ingest_pipelines ?? _ip ?? _ingestPipelines;
		public string? IngestTime => _ingest_time ?? _it ?? _ingestTime;
		public string? License => _l ?? _license;
		public string? Operations => _operations ?? _o ?? _modelOperations;
		public VersionString? Version => _v ?? _version;
	}
}