using Newtonsoft.Json;

namespace AGLChallenge.Services.Models
{
	public class Pets
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}
}