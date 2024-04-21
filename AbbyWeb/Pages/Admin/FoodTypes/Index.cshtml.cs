using Abby.DataAccess.Repositry.IRepositry;
using Abby.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AbbyWeb.Pages.Admin.FoodTypes;

public class IndexModel : PageModel
{
	private readonly IUnitOfWork _unitOfWork;

	public IEnumerable<FoodType> FoodTypes { get; set; }

	public IndexModel(IUnitOfWork unitOfWork)
	{
		_unitOfWork = unitOfWork;
	}

	public void OnGet()
    {
		FoodTypes = _unitOfWork.FoodType.GetAll();
    }
}
