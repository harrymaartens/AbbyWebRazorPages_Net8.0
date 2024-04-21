using Abby.DataAccess.Data;
using Abby.DataAccess.Repositry.IRepositry;

namespace Abby.DataAccess.Repositry
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
			Category = new CategoryRepositry(_db);
			FoodType = new FoodTypeRepositry(_db);
			MenuItem = new MenuItemRepositry(_db);
		}

        public ICategoryRepositry Category {  get; private set; }

		public IFoodTypeRepositry FoodType { get; private set; }

		public IMenuItemRepositry MenuItem { get; private set; }

		public void Dispose()
		{
			_db.Dispose();
		}

		public void Save()
		{
			_db.SaveChanges();
		}
	}
}
