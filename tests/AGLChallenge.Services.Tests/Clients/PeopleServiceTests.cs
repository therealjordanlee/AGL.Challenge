using AGLChallenge.Services.Clients;

namespace AGLChallenge.Services.Tests.Clients
{
	public class PeopleServiceTests
	{
		private HttpClient _httpClient;

		public PeopleServiceTests()
		{
			_httpClient = new HttpClient();
			_httpClient.BaseAddress = new Uri("http://agl-developer-test.azurewebsites.net");
			_httpClient.DefaultRequestHeaders.Add("Accept", "application/json");
			_httpClient.DefaultRequestHeaders.Add("User-Agent", "Unit Test");
		}

		[Fact]
		public async Task Expect_GetPeople_Returns_List_Of_People()
		{
			var peopleService = new PeopleService(_httpClient);

			var result = await peopleService.GetPeople();

			Assert.Collection(result,
				item =>
				{
					Assert.Equal("Bob", item.Name);
					Assert.Equal("Male", item.Gender);
					Assert.Equal(23, item.Age);
					Assert.Equal(2, item.Pets.Count());
				},
				item =>
				{
					Assert.Equal("Jennifer", item.Name);
					Assert.Equal("Female", item.Gender);
					Assert.Equal(18, item.Age);
					Assert.Equal(1, item.Pets.Count());
				},
				item =>
				{
					Assert.Equal("Steve", item.Name);
					Assert.Equal("Male", item.Gender);
					Assert.Equal(45, item.Age);
					Assert.Null(item.Pets);
				},
				item =>
				{
					Assert.Equal("Fred", item.Name);
					Assert.Equal("Male", item.Gender);
					Assert.Equal(40, item.Age);
					Assert.Equal(4, item.Pets.Count());
				},
				item =>
				{
					Assert.Equal("Samantha", item.Name);
					Assert.Equal("Female", item.Gender);
					Assert.Equal(40, item.Age);
					Assert.Equal(1, item.Pets.Count());
				},
				item =>
				{
					Assert.Equal("Alice", item.Name);
					Assert.Equal("Female", item.Gender);
					Assert.Equal(64, item.Age);
					Assert.Equal(2, item.Pets.Count());
				}
				);
		}
	}
}