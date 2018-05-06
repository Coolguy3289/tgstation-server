﻿using System.Threading;
using System.Threading.Tasks;
using Tgstation.Server.Host.Models;

namespace Tgstation.Server.Host.Components
{
	/// <summary>
	/// For managing <see cref="IInstance"/>s
	/// </summary>
	interface IInstanceManager : IInstanceShutdownHandler
	{
		/// <summary>
		/// Get the <see cref="IInstance"/> associated with given <paramref name="metadata"/>
		/// </summary>
		/// <param name="metadata">The <see cref="Host.Models.Instance"/> of the desired <see cref="IInstance"/></param>
		/// <returns>The <see cref="IInstance"/> associated with the given <paramref name="metadata"/></returns>
		IInstance GetInstance(Host.Models.Instance metadata);

		/// <summary>
		/// Online an <see cref="IInstance"/>
		/// </summary>
		/// <param name="metadata">The <see cref="Host.Models.Instance"/> of the desired <see cref="IInstance"/></param>
		/// <param name="databaseContext">The <see cref="IDatabaseContext"/> for the operation</param>
		/// <param name="cancellationToken">The <see cref="CancellationToken"/> for the operation</param>
		/// <returns>A <see cref="Task"/> representing the running operation</returns>
		Task OnlineInstance(Host.Models.Instance metadata, IDatabaseContext databaseContext, CancellationToken cancellationToken);

		/// <summary>
		/// Offline an <see cref="IInstance"/>
		/// </summary>
		/// <param name="metadata">The <see cref="Host.Models.Instance"/> of the desired <see cref="IInstance"/></param>
		/// <param name="cancellationToken">The <see cref="CancellationToken"/> for the operation</param>
		/// <returns>A <see cref="Task"/> representing the running operation</returns>
		Task OfflineInstance(Host.Models.Instance metadata, CancellationToken cancellationToken);

		/// <summary>
		/// Move an <see cref="IInstance"/>
		/// </summary>
		/// <param name="metadata">The <see cref="Host.Models.Instance"/> of the desired <see cref="IInstance"/></param>
		/// <param name="databaseContext">The <see cref="IDatabaseContext"/> for the operation</param>
		/// <param name="newPath">The new path of the <see cref="IInstance"/>. <paramref name="metadata"/> will have this set on <see cref="Api.Models.Instance.Path"/> if the operation completes successfully</param>
		/// <param name="cancellationToken">The <see cref="CancellationToken"/> for the operation</param>
		/// <returns>A <see cref="Task"/> representing the running operation</returns>
		Task MoveInstance(Host.Models.Instance metadata, IDatabaseContext databaseContext, string newPath, CancellationToken cancellationToken);
	}
}