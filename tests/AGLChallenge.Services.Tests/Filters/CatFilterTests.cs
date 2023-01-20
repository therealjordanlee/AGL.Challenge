using AGLChallenge.Services.Filters;
using AGLChallenge.Services.Models;
using Newtonsoft.Json;

namespace AGLChallenge.Services.Tests.Services
{
	public class FilterByCatAndOwnerGenderTests
	{
		private FilterByCatAndOwnerGender _sut;

		public FilterByCatAndOwnerGenderTests()
		{
			_sut = new FilterByCatAndOwnerGender();
		}

		[Fact]
		public void Expect_Filter_Returns_Correct_Result()
		{
			var json = @"
[{""name"":""Bob"",""gender"":""Male"",""age"":23,""pets"":[{""name"":""Garfield"",""type"":""Cat""},{""name"":""Fido"",""type"":""Dog""}]},{""name"":""Jennifer"",""gender"":""Female"",""age"":18,""pets"":[{""name"":""Garfield"",""type"":""Cat""}]},{""name"":""Steve"",""gender"":""Male"",""age"":45,""pets"":null},{""name"":""Fred"",""gender"":""Male"",""age"":40,""pets"":[{""name"":""Tom"",""type"":""Cat""},{""name"":""Max"",""type"":""Cat""},{""name"":""Sam"",""type"":""Dog""},{""name"":""Jim"",""type"":""Cat""}]},{""name"":""Samantha"",""gender"":""Female"",""age"":40,""pets"":[{""name"":""Tabby"",""type"":""Cat""}]},{""name"":""Alice"",""gender"":""Female"",""age"":64,""pets"":[{""name"":""Simba"",""type"":""Cat""},{""name"":""Nemo"",""type"":""Fish""}]}]
";

			var people = JsonConvert.DeserializeObject<List<People>>(json);
			var result = _sut.Filter(people);

			Assert.Equal(7, result.Count());
		}
	}
}