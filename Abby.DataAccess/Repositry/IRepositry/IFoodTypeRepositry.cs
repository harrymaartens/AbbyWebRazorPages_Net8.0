using Abby.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.DataAccess.Repositry.IRepositry
{
	public interface IFoodTypeRepositry : IRepositry<FoodType>
	{
		void Update(FoodType obj);
	}
}
