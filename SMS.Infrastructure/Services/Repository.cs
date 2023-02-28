using Microsoft.EntityFrameworkCore;
using SMS.Infrastructure.Constracts;
using SMS.Infrastructure.Sql;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SMS.Infrastructure.Services
{
	public class Repository<T> : IRepository<T> where T : class
	{
		private readonly AppDbContext _db;
		internal DbSet<T> _dbSet;

		#region Constructor
		public Repository(AppDbContext db)
		{
			_db = db;
			_dbSet = _db.Set<T>();
		}
		#endregion Constructor

		#region Add
		public T Add(T entity)
		{
			return _dbSet.Add(entity).Entity;
		}
		#endregion Add

		#region FirstOrDefaultAsync
		public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> filter, string? includeProperties = null)
		{
			IQueryable<T> query = _dbSet.AsQueryable().AsNoTracking();
			query =  query.Where(filter);

			if (includeProperties != null)
			{
				foreach (var item in includeProperties.Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries))
				{
					query.Include(item);
				}
			}
			return await query.FirstOrDefaultAsync();
		}
		#endregion FirstOrDefaultAsync

		#region QueryAsync
		public async Task<IEnumerable<T>> QueryAsync(Expression<Func<T, bool>>? filter, string? includeProperties = null)
		{
			IQueryable<T> query = _dbSet.AsQueryable().AsNoTracking();

			if (filter != null)
			{
				query = query.Where(filter);
			}

			if (includeProperties != null)
			{
				foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
				{
					query.Include(item);
				}
			}

			return await query.ToListAsync();
		}
		#endregion QueryAsync

		#region Update
		public void Update(T entity)
		{
			_db.Entry(entity).State = EntityState.Modified;
			_dbSet.Update(entity);
		}
		#endregion Update

		#region Delete
		public void Delete(T entity)
		{
			_db.Entry(entity).State = EntityState.Deleted;
			_dbSet.Remove(entity);
		}
		#endregion Delete

		#region Remove
		public void Remove(T entity)
		{
			_db.Entry(entity).State = EntityState.Modified;
			_dbSet.Update(entity);
		}
		#endregion Remove
	}
}