// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗  
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝  
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// -----------------------------------------------
//  
// This file is automatically generated 
// Please do not edit these files manually
// Run the following in the root of the repos:
//
// 		*NIX 		:	./build.sh codegen
// 		Windows 	:	build.bat codegen
//
// -----------------------------------------------
// ReSharper disable RedundantUsingDirective
using System;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
// ReSharper disable RedundantTypeArgumentsOfMethod
namespace Nest.Specification.SqlApi
{
	///<summary>
	/// Logically groups all <c>Sql</c> API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticClient.Sql"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class SqlNamespace : NamespacedClientProxy
	{
		internal SqlNamespace(ElasticClient client): base(client)
		{
		}

		/// <summary>
		/// <c>POST</c> request to the <c>sql.clear_cursor</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Clear SQL cursor">Clear SQL cursor</a>
		/// </summary>
		public ClearSqlCursorResponse ClearCursor(Func<ClearSqlCursorDescriptor, IClearSqlCursorRequest> selector) => ClearCursor(selector.InvokeOrDefault(new ClearSqlCursorDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>sql.clear_cursor</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Clear SQL cursor">Clear SQL cursor</a>
		/// </summary>
		public Task<ClearSqlCursorResponse> ClearCursorAsync(Func<ClearSqlCursorDescriptor, IClearSqlCursorRequest> selector, CancellationToken ct = default) => ClearCursorAsync(selector.InvokeOrDefault(new ClearSqlCursorDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.clear_cursor</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Clear SQL cursor">Clear SQL cursor</a>
		/// </summary>
		public ClearSqlCursorResponse ClearCursor(IClearSqlCursorRequest request) => DoRequest<IClearSqlCursorRequest, ClearSqlCursorResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.clear_cursor</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Clear SQL cursor">Clear SQL cursor</a>
		/// </summary>
		public Task<ClearSqlCursorResponse> ClearCursorAsync(IClearSqlCursorRequest request, CancellationToken ct = default) => DoRequestAsync<IClearSqlCursorRequest, ClearSqlCursorResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.query</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Execute SQL">Execute SQL</a>
		/// </summary>
		public QuerySqlResponse Query(Func<QuerySqlDescriptor, IQuerySqlRequest> selector = null) => Query(selector.InvokeOrDefault(new QuerySqlDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>sql.query</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Execute SQL">Execute SQL</a>
		/// </summary>
		public Task<QuerySqlResponse> QueryAsync(Func<QuerySqlDescriptor, IQuerySqlRequest> selector = null, CancellationToken ct = default) => QueryAsync(selector.InvokeOrDefault(new QuerySqlDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.query</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Execute SQL">Execute SQL</a>
		/// </summary>
		public QuerySqlResponse Query(IQuerySqlRequest request) => DoRequest<IQuerySqlRequest, QuerySqlResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.query</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Execute SQL">Execute SQL</a>
		/// </summary>
		public Task<QuerySqlResponse> QueryAsync(IQuerySqlRequest request, CancellationToken ct = default) => DoRequestAsync<IQuerySqlRequest, QuerySqlResponse>(request, request.RequestParameters, ct);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.translate</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Translate SQL into Elasticsearch queries">Translate SQL into Elasticsearch queries</a>
		/// </summary>
		public TranslateSqlResponse Translate(Func<TranslateSqlDescriptor, ITranslateSqlRequest> selector = null) => Translate(selector.InvokeOrDefault(new TranslateSqlDescriptor()));
		/// <summary>
		/// <c>POST</c> request to the <c>sql.translate</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Translate SQL into Elasticsearch queries">Translate SQL into Elasticsearch queries</a>
		/// </summary>
		public Task<TranslateSqlResponse> TranslateAsync(Func<TranslateSqlDescriptor, ITranslateSqlRequest> selector = null, CancellationToken ct = default) => TranslateAsync(selector.InvokeOrDefault(new TranslateSqlDescriptor()), ct);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.translate</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Translate SQL into Elasticsearch queries">Translate SQL into Elasticsearch queries</a>
		/// </summary>
		public TranslateSqlResponse Translate(ITranslateSqlRequest request) => DoRequest<ITranslateSqlRequest, TranslateSqlResponse>(request, request.RequestParameters);
		/// <summary>
		/// <c>POST</c> request to the <c>sql.translate</c> API, read more about this API online:
		/// <para> </para>
		/// <a href = "Translate SQL into Elasticsearch queries">Translate SQL into Elasticsearch queries</a>
		/// </summary>
		public Task<TranslateSqlResponse> TranslateAsync(ITranslateSqlRequest request, CancellationToken ct = default) => DoRequestAsync<ITranslateSqlRequest, TranslateSqlResponse>(request, request.RequestParameters, ct);
	}
}