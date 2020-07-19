using Microsoft.EntityFrameworkCore;
using QuickBuy.Dominio.ObjetoDeValor;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);
        }
    }
}
