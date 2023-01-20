using System.Collections.Generic;
using Newtonsoft.Json;

namespace AGLChallenge.Services.Models
{
	public class People
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("gender")]
		public string Gender { get; set; }

		[JsonProperty("age")]
		public int Age { get; set; }

		[JsonProperty("pets")]
		public IEnumerable<Pets>? Pets { get; set; }
	}
}