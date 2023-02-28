using Microsoft.AspNetCore.Mvc;
using SMS.Domain.Entities;
using SMS.Infrastructure.Constracts;
using SMS.Utilities.Constants;

namespace SMS.Api.Controllers
{
	[Route(RouteConstant.BaseRoute)]
	[ApiController]
	public class EmployeesController : ControllerBase
	{
		private readonly IUnitOfWork _context;

		public EmployeesController(IUnitOfWork context)
		{
			_context = context;
		}

		#region CreateEmployee
		public Task<IActionResult> CreateEmployee(Employee model)
		{
			try
			{

			}
			catch (Exception)
			{

				throw;
			}
		}
		#endregion CreateEmployee
	}
}
