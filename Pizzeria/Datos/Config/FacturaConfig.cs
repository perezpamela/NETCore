using Datos.Modelos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Config
{
    class FacturaConfig
    {
        public FacturaConfig(EntityTypeBuilder<Factura> entityBuilder)
        {
            entityBuilder.Property(f => f.FormaDePago).IsRequired();
        }
    }
}
