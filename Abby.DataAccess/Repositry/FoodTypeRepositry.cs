using Abby.DataAccess.Data;
using Abby.DataAccess.Repositry.IRepositry;
using Abby.Models;

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
