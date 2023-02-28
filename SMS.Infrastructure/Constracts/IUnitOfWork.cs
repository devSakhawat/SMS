namespace SMS.Infrastructure.Constracts
{
	public interface IUnitOfWork
	{
		Task<int> SaveChangesAsync();
		IEmployeeRepository Employee { get; }
		IPaymentRecordRepository PaymentRecord { get; }
		ITaxYearRepository TaxYear { get; }
	}
}