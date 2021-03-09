using Datos.Modelos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Config
{
    class IngredienteConfig
    {
        public IngredienteConfig(EntityTypeBuilder<Ingrediente> entityBuilder)
        {
            entityBuilder.HasIndex(i => i.Nombre).IsUnique();
            entityBuilder.Property(i => i.Nombre).HasMaxLength(70).IsRequired();
        }
    }
}
