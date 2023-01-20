using AGLChallenge.Services.Clients;
using AGLChallenge.Services.Configuration;
using AGLChallenge.Services.Filters;
using AGLChallenge.Services.Models;
using AGLChallenge.Services.Services;

namespace AGLChallenge.Blazor
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddRazorPages();
			builder.Services.AddServerSideBlazor();
			builder.Services.AddHttpClient<IPeopleService, PeopleService>(c =>
			{
				var options = builder.Configuration.GetSection(nameof(PeopleServiceOptions)).Get<PeopleServiceOptions>();
				if (options == null)
					throw new NullReferenceException(nameof(PeopleServiceOptions));
				c.BaseAddress = new Uri(options.BaseUrl);
			});

			builder.Services.AddScoped<IPeopleFilter<CatFilterResult>, FilterByCatAndOwnerGender>();

			var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseStaticFiles();

			app.UseRouting();

			app.MapBlazorHub();
			app.MapFallbackToPage("/_Host");

			app.Run();
		}
	}
}