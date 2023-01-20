using System.Collections.Generic;
using System.Threading.Tasks;
using AGLChallenge.Services.Models;

namespace AGLChallenge.Services.Clients
{
	public interface IPeopleService
	{
		/// <summary>
		/// Returns a collection of <see cref="People"/> from the AGL challenge API.
		/// </summary>
		/// <returns>A collection of <see cref="People"/></returns>
		Task<IEnumerable<People>?> GetPeople();
	}
}