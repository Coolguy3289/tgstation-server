﻿using Tgstation.Server.Host.Models;

namespace Tgstation.Server.Host.Components
{
	/// <summary>
	/// Factory for creating <see cref="IInstance"/>s
	/// </summary>
	interface IInstanceFactory
	{
		/// <summary>
		/// Create an <see cref="IInstance"/>
		/// </summary>
		/// <param name="metadata">The <see cref="Host.Models.Instance"/></param>
		///	<param name="databaseContext">The <see cref="IDatabaseContext"/> for the operation</param>
		/// <returns>A new <see cref="IInstance"/></returns>
		IInstance CreateInstance(Host.Models.Instance metadata, IDatabaseContext databaseContext);
	}
}