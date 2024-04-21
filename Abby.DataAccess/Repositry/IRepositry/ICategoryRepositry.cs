using Abby.Models;

namespace Abby.DataAccess.Repositry.IRepositry
{
	public interface ICategoryRepositry : IRepositry<Category>
	{
		void Update(Category category);
	}
}
