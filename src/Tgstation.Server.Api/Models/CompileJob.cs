﻿namespace Tgstation.Server.Api.Models
{
	/// <inheritdoc />
	public sealed class CompileJob : Internal.CompileJob
	{
		/// <summary>
		/// The <see cref="Job"/> relating to this job
		/// </summary>
		public Job Job { get; set; }

		/// <summary>
		/// Git revision the compiler ran on. Not modifiable
		/// </summary>
		public RevisionInformation RevisionInformation { get; set; }
	}
}