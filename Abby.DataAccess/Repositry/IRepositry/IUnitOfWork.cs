
namespace Abby.DataAccess.Repositry.IRepositry
{
	public interface IUnitOfWork : IDisposable
	{
		ICategoryRepositry Category {  get; }
		IFoodTypeRepositry FoodType { get; }
		IMenuItemRepositry MenuItem { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IOrderHeaderRepository OrderHeader { get; }
        IOrderDetailRepository OrderDetail { get; }
        IApplicationUserRepository ApplicationUser { get; }
        void Save();
	}
}
