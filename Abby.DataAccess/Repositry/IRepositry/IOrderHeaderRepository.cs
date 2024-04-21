using Abby.Models;

namespace Abby.DataAccess.Repositry.IRepositry
{
	public interface IOrderHeaderRepository : IRepositry<OrderHeader>
	{
		void Update(OrderHeader obj);
	}
}
