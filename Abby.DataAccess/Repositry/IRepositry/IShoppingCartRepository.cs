using Abby.Models;

namespace Abby.DataAccess.Repositry.IRepositry
{
	public interface IShoppingCartRepository : IRepositry<ShoppingCart>
	{
		int IncrementCount(ShoppingCart shoppingCart, int count);
		int DecrementCount(ShoppingCart shoppingCart, int count);
	}
}
