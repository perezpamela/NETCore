using Datos.Modelos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Config
{
    class PizzaConfig
    {
        public PizzaConfig(EntityTypeBuilder<Pizza> entityBuilder)
        {
            entityBuilder.HasIndex(p => p.Variedad).IsUnique();
            entityBuilder.Property(p => p.Variedad).HasMaxLength(70).IsRequired();
            entityBuilder.Property(p => p.Precio).IsRequired();
        }
    }
}
