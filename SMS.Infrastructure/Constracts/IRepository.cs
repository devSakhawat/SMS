using System.Linq.Expressions;

namespace SMS.Infrastructure.Constracts
{
	public interface IRepository<T>
	{
		// Create a row in the table.
		T Add(T entity);

		// Returns first matched row as an object from the table.
		Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> filter, string? includeProperties = null);

		// Return rows from table.
		Task<IEnumerable<T>> QueryAsync(Expression<Func<T, bool>>? filter, string? includeProperties = null);

		// Updates an existing row in the table.
		void Update(T entity);

		// Delete a row from the table.
		void Delete(T entity);

		// Hide a row from list (Soft Delete)
		void Remove(T entity);
	}
}