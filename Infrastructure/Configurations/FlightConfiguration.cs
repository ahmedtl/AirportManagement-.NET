﻿using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasMany(f => f.Passengers).
                WithMany(p => p.flights).
                UsingEntity(i => i.ToTable("MyReservations"));

            builder.HasOne(f => f.MyPlane).
                WithMany(p => p.flights).
                HasForeignKey(f => f.PlaneId).
                OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
