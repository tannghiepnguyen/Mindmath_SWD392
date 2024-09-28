﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mindmath.Domain.Models;

namespace Mindmath.Infrastructure.Configuration
{
	public class DepositConfiguration : IEntityTypeConfiguration<Deposit>
	{
		public void Configure(EntityTypeBuilder<Deposit> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Amount).IsRequired();
			builder.Property(x => x.Description).IsRequired();
			builder.Property(x => x.CreatedAt).IsRequired();
			builder.HasOne(x => x.Wallet).WithMany(x => x.Deposits).HasForeignKey(x => x.WalletId).OnDelete(DeleteBehavior.Restrict);
		}
	}
}