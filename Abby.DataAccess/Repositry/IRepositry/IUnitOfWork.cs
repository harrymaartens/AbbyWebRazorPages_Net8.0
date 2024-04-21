using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.DataAccess.Repositry.IRepositry
{
	public interface IUnitOfWork : IDisposable
	{
		ICategoryRepositry Category {  get; }
		IFoodTypeRepositry FoodType { get; }
		void Save();
	}
}
