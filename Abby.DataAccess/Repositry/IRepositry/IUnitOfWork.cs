
namespace Abby.DataAccess.Repositry.IRepositry
{
	public interface IUnitOfWork : IDisposable
	{
		ICategoryRepositry Category {  get; }
		IFoodTypeRepositry FoodType { get; }
		IMenuItemRepositry MenuItem { get; }
        IShoppingCartRepository ShoppingCart { get; }
        void Save();
	}
}
