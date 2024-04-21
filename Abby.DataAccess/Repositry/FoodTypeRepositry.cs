using Abby.DataAccess.Data;
using Abby.DataAccess.Repositry.IRepositry;
using Abby.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Abby.DataAccess.Repositry
{
	public class FoodTypeRepositry : Repositry<FoodType>, IFoodTypeRepositry
	{
		private readonly ApplicationDbContext _db;

        public FoodTypeRepositry(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

		public void Update(FoodType obj)
		{
			var objFromDb = _db.FoodType.FirstOrDefault(u =>  u.Id == obj.Id);
			objFromDb.Name = obj.Name;
		}
	}
}
