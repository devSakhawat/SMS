using SMS.Domain.Entities;
using SMS.Infrastructure.Constracts;
using SMS.Infrastructure.Sql;

namespace SMS.Infrastructure.Services
{
	public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
	{
		public EmployeeRepository(AppDbContext db) : base(db)
		{
		}
	}
}