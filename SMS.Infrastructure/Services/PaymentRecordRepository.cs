using SMS.Domain.Entities;
using SMS.Infrastructure.Constracts;
using SMS.Infrastructure.Sql;

namespace SMS.Infrastructure.Services
{
	public class PaymentRecordRepository : Repository<PaymentRecord>, IPaymentRecordRepository
	{
		public PaymentRecordRepository(AppDbContext db) : base(db)
		{
		}
	}
}