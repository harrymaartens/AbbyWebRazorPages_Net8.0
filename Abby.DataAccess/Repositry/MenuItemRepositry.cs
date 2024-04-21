using Abby.DataAccess.Data;
using Abby.DataAccess.Repositry.IRepositry;
using Abby.Models;

namespace Abby.DataAccess.Repositry
{
	public class MenuItemRepositry : Repositry<MenuItem>, IMenuItemRepositry
	{
		private readonly ApplicationDbContext _db;

        public MenuItemRepositry(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }       

		public void Update(MenuItem obj)
		{
			var objFromDb = _db.MenuItem.FirstOrDefault(u =>  u.Id == obj.Id);
			objFromDb.Name = obj.Name;
			objFromDb.Description = obj.Description;
			objFromDb.Price = obj.Price;
			objFromDb.CategoryId = obj.CategoryId;
			objFromDb.FoodTypeId = obj.FoodTypeId;
			if (objFromDb.Image != null)
			{
				objFromDb.Image = obj.Image;
			}
		}
	}
}
