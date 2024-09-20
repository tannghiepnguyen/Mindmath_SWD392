﻿using Mindmath.Domain.Repository;
using Mindmath.Infrastructure.Persistence;

namespace Mindmath.Infrastructure.Repository
{
	public sealed class RepositoryManager : IRepositoryManager
	{
		private readonly MindmathDbContext _context;
		public RepositoryManager(MindmathDbContext context)
		{
			_context = context;
		}
		public void Save() => _context.SaveChanges();
	}
}