using Datos.Modelos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Config
{
    class PedidoConfig
    {
        public PedidoConfig(EntityTypeBuilder<Pedido> entityBuilder)
        {
            entityBuilder.Property(p => p.ClienteNombre).HasMaxLength(70).IsRequired();
            entityBuilder.Property(p => p.Fecha).IsRequired();
            entityBuilder.Property(p => p.Demora).IsRequired();
        }
    }
}
