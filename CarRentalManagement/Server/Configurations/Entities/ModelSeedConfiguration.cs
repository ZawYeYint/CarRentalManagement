﻿using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
	public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
	{
		public void Configure(EntityTypeBuilder<Model> builder)
		{
			builder.HasData
			(
				new Model
				{
					Id = 1,
					Name = "3 Series",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Model
				{
					Id = 2,
					Name = "X5",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				},
				new Model
				{
					Id = 3,
					Name = "Rav4",
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					CreatedBy = "System",
					UpdatedBy = "System"
				}
			);
		}
	}
}
