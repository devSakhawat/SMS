using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Domain.Entities
{
	public class TaxYear : BaseModel
	{
		public int Id { get; set; }
		public string YearOfTax { get; set; }
		public IEnumerable<PaymentRecord> PaymentRecords { get; set; }
	}
}
