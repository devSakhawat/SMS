namespace SMS.Utilities.Constants
{
	public static class RouteConstant
	{
		public const string BaseRoute = "SMS";

		#region Employee
		public const string CreateEmployee = "employee";
		public const string ReadEmployeeByKey = "employee/key/{key}";
		public const string ReadEmployees = "employees";
		public const string UpdateEmployee = "employee/{key}";
		public const string DeleteEmployee = "employee/{key}";
		#endregion Employee

		#region PaymentRecord
		public const string CreatePaymentRecord = "payment-record";
		public const string ReadPaymentRecordByKey = "payment-record/key/{key}";
		public const string ReadPaymentRecords = "payment-records";
		public const string UpdatePaymentRecord = "payment-record/{key}";
		public const string DeletePaymentRecord = "payment-record/{key}";
		#endregion PaymentRecord

		#region TaxYear
		public const string CreateTaxYear = "tax-year";
		public const string ReadTaxYearByKey = "tax-year/key/{key}";
		public const string ReadTaxYears = "tax-years";
		public const string UpdateTaxYear = "tax-year/{key}";
		public const string DeleteTaxYear = "tax-year/{key}";
		#endregion TaxYear
	}
}