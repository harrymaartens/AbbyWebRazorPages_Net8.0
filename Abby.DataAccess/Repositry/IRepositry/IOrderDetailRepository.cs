using Abby.Models;

namespace Abby.DataAccess.Repositry.IRepositry
{
	public interface IOrderDetailRepository : IRepositry<OrderDetails>
	{
		void Update(OrderDetails obj);
	}
}
