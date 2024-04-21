using Abby.DataAccess.Data;
using Abby.DataAccess.Repositry.IRepositry;
using Abby.Models;

namespace Abby.DataAccess.Repositry
{
	public class CategoryRepositry : Repositry<Category>, ICategoryRepositry
	{
		private readonly ApplicationDbContext _db;

        public CategoryRepositry(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
		{
			_db.SaveChanges();
		}

		public void Update(Category category)
		{
			var objFromDb = _db.Category.FirstOrDefault(u => u.Id == category.Id);
			objFromDb.Name = category.Name;
			objFromDb.DisplayOrder = category.DisplayOrder;
		}
	}
}
