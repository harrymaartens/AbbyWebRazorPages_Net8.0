using Abby.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.DataAccess.Repositry.IRepositry
{
	public interface ICategoryRepositry : IRepositry<Category>
	{
		void Update(Category category);


	}
}
