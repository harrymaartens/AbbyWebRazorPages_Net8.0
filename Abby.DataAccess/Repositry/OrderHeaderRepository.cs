using Abby.DataAccess.Data;
using Abby.DataAccess.Repositry.IRepositry;
using Abby.Models;

namespace Abby.DataAccess.Repositry
{
	public class OrderHeaderRepository : Repositry<OrderHeader>, IOrderHeaderRepository
	{
		private readonly ApplicationDbContext _db;

        public OrderHeaderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
		        
		public void Update(OrderHeader obj)
		{
			_db.OrderHeader.Update(obj);
		}
	}
}
