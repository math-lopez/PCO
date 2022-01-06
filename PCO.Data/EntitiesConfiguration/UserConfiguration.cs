using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PCO.Domain.Entities;
using System;

namespace PCO.Data.EntitiesConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Definindo chave primaria
            builder.HasKey(x => x.Id);
            
            //Definindo regras padrões para cada coluna(propriedade)
            builder.Property(p => p.FullName).IsRequired().HasMaxLength(100);
            builder.Property(p => p.BirthDate).IsRequired();
            builder.Property(p => p.Password).IsRequired().HasMaxLength(100);
            builder.Property(p => p.UserName).IsRequired();

            //Configurando a inserção de dados quando rodar a migration
            builder.HasData(
                new User(1, "Matheus Lopes de Jesus", new DateTime(1999, 10, 07), "12345678", "do um ao oito", "mathjes"),
                new User(2, "Rayane Lopes de Jesus", new DateTime(2001, 12, 04), "87654312", "do oito ao um", "rayjes"),
                new User(3, "Bruna Lopes de Jesus", new DateTime(2001, 12, 04), "87654312", "do oito ao um", "brujes")
                );
        }
    }
}
