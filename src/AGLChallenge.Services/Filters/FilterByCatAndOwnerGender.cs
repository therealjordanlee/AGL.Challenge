using System.Collections.Generic;
using System.Linq;
using AGLChallenge.Services.Models;
using AGLChallenge.Services.Services;

namespace AGLChallenge.Services.Filters
{
	public class FilterByCatAndOwnerGender : IPeopleFilter<CatFilterResult>
	{
		/// <summary>
		/// Filters a collection of <see cref="People"/> by those with pet cats, and returns a collection of <see cref="CatFilterResult"/>s
		/// </summary>
		/// <param name="people"></param>
		/// <returns></returns>
		public IEnumerable<CatFilterResult> Filter(IEnumerable<People> people)
		{
			//var cats = new List<CatFilterResult>();
			//people.Where(x => x.Pets != null).ToList().ForEach(x =>
			//{
			//	foreach (var pet in x.Pets)
			//	{
			//		if (pet.Type == "Cat")
			//			cats.Add(new CatFilterResult
			//			{
			//				Name = pet.Name,
			//				Gender = x.Gender
			//			});
			//	}
			//});

			var result = people.Where(person => person.Pets != null)
							   .SelectMany(person =>
							   {
								   var petCats = person.Pets.Where(p => p.Type == "Cat")
															.Select(c =>
															 {
																 return new CatFilterResult
																 {
																	 Name = c.Name,
																	 Gender = person.Gender
																 };
															 });
								   return petCats;
							   });
			return result;
		}
	}
}