#if XUNIT_NULLABLE
#nullable enable
#endif

using System;

namespace Xunit.Sdk
{
	/// <summary>
	/// Exception thrown when <see cref="Assert.Distinct{T}(System.Collections.Generic.IEnumerable{T})" />
	/// or <see cref="Assert.Distinct{T}(System.Collections.Generic.IEnumerable{T}, System.Collections.Generic.IEqualityComparer{T})" />
	/// finds a duplicate entry in the collection.
	/// </summary>
#if XUNIT_VISIBILITY_INTERNAL
	internal
#else
	public
#endif
	class DistinctException : XunitException
	{
		DistinctException(string message) :
			base(message)
		{ }

		/// <summary>
		/// Creates an instance of the <see cref="DistinctException"/> class that is thrown
		/// when a duplicate item is found in a collection.
		/// </summary>
		/// <param name="item">The duplicate item</param>
		/// <param name="collection">The collection</param>
		public static DistinctException ForDuplicateItem(
			string item,
			string collection) =>
				new DistinctException(
					"Assert.Distinct() Failure: Duplicate item found" + Environment.NewLine +
					"Collection: " + collection + Environment.NewLine +
					"Item:       " + item
				);
	}
}
