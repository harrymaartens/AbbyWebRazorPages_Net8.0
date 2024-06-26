﻿using Abby.DataAccess.Data;
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

        public void UpdateStatus(int id, string status)
        {
            var orderFromDb = _db.OrderHeader.FirstOrDefault(u => u.Id == id);
            if (orderFromDb != null) 
            {
                orderFromDb.Status = status;
            }
        }
    }
}
