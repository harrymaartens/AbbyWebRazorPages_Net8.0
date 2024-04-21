using Abby.Models;

namespace Abby.DataAccess.Repositry.IRepositry
{
	public interface IFoodTypeRepositry : IRepositry<FoodType>
	{
		void Update(FoodType obj);
	}
}
