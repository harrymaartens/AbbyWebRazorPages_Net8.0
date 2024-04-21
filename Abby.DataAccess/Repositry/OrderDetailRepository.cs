using Abby.DataAccess.Data;
using Abby.DataAccess.Repositry.IRepositry;
using Abby.Models;

namespace Abby.DataAccess.Repositry
{
	public class OrderDetailRepository : Repositry<OrderDetails>, IOrderDetailRepository
	{
		private readonly ApplicationDbContext _db;

        public OrderDetailRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

		public void Update(OrderDetails obj)
		{
			_db.OrderDetails.Update(obj);
		}
	}
}
