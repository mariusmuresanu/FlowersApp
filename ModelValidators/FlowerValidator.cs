using FlowersApp.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowersApp.ModelValidators
{
    public class FlowerValidator : AbstractValidator<Flower> 
	{
		public FlowerValidator(FlowersDbContext context)
		{

			RuleFor(x => x.MarketPrice)
				.InclusiveBetween(5, context.Flowers.Select(f => f.MarketPrice).Max());
			RuleFor(x => x.DateAdded)
				.LessThan(DateTime.Now);
			RuleFor(x => x.flowerUpkeepDifficulty)
				.Equal(flowerUpkeepDifficulty.Easy)
				.When(x => x.MarketPrice >= 5 && x.MarketPrice <= 10);
		}
	}
}
