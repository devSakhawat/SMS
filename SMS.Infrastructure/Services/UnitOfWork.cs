using SMS.Infrastructure.Constracts;
using SMS.Infrastructure.Sql;

namespace SMS.Infrastructure.Services
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly AppDbContext _db;

		public UnitOfWork(AppDbContext db)
		{
			_db = db;
			Employee = new EmployeeRepository(_db);
			PaymentRecord = new PaymentRecordRepository(_db);
			TaxYear = new TaxYearRepository(_db);
		}

		public async Task<int> SaveChangesAsync()
		{
			return await _db.SaveChangesAsync();
		}

		public IEmployeeRepository Employee { get; private set; }
		public ITaxYearRepository TaxYear { get; private set; }
		public IPaymentRecordRepository PaymentRecord { get; private set; }

	}
}