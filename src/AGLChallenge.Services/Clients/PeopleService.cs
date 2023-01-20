using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AGLChallenge.Services.Models;
using Newtonsoft.Json;

namespace AGLChallenge.Services.Clients
{
	public class PeopleService : IPeopleService
	{
		private readonly HttpClient _httpClient;

		public PeopleService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		/// <summary>
		/// <see cref="IPeopleService.GetPeople"/>
		/// </summary>
		public async Task<IEnumerable<People>?> GetPeople()
		{
			var response = await _httpClient.GetAsync("people.json");
			response.EnsureSuccessStatusCode();

			var contentString = await response.Content.ReadAsStringAsync();
			var result = JsonConvert.DeserializeObject<List<People>>(contentString);
			return result;
		}
	}
}