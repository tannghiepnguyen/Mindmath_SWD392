﻿using Microsoft.EntityFrameworkCore;
using Mindmath.Domain.Repository;
using Mindmath.Infrastructure.Persistence;
using System.Linq.Expressions;

namespace Mindmath.Infrastructure.Repository
{
	public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
	{
		protected MindmathDbContext _context;
		public RepositoryBase(MindmathDbContext context)
		{
			_context = context;
		}
		public void Create(T entity) => _context.Set<T>().Add(entity);

		public void Delete(T entity) => _context.Set<T>().Remove(entity);

		public IQueryable<T> FindAll(bool trackChanges) =>
			!trackChanges ?
			_context.Set<T>().AsNoTracking() :
			_context.Set<T>();

		public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges) =>
			!trackChanges ?
		  _context.Set<T>()
			.Where(expression)
			.AsNoTracking() :
		  _context.Set<T>()
			.Where(expression);

		public void Update(T entity) => _context.Set<T>().Update(entity);
	}
}
