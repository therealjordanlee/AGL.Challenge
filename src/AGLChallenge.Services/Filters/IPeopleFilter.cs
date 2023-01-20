using System.Collections.Generic;
using AGLChallenge.Services.Models;

namespace AGLChallenge.Services.Services
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IPeopleFilter<T>
	{
		/// <summary>
		/// Filters a collections of <see cref="People"/> based on some condition, and projects the result to an <see cref="IEnumerable{T}"/>
		/// </summary>
		/// <param name="people">An IEnumerable of <see cref="People"/></param>
		/// <returns></returns>
		IEnumerable<T> Filter(IEnumerable<People> people);
	}
}