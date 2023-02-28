using SMS.Domain.Entities;
using SMS.Infrastructure.Constracts;
using SMS.Infrastructure.Sql;

namespace SMS.Infrastructure.Services
{
	public class TaxYearRepository : Repository<TaxYear>, ITaxYearRepository
	{
		public TaxYearRepository(AppDbContext db) : base(db)
		{
		}
	}
}