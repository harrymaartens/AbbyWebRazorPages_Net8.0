using Abby.DataAccess.Data;
using Abby.DataAccess.Repositry.IRepositry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public ICategoryRepositry Category {  get; private set; }

		public IFoodTypeRepositry FoodType { get; private set; }

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
