using Abby.DataAccess.Data;
using Abby.DataAccess.Repositry.IRepositry;
using Abby.Models;

namespace Abby.DataAccess.Repositry
{
	public class ApplicationUserRepository : Repositry<ApplicationUser>, IApplicationUserRepository
	{
		private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }        
	}
}
