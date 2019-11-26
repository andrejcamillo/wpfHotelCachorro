 using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HotelCachorro.Model
{
    class Context : DbContext
    {
        public Context () : base("HotelCachorroDB") { }
        public DbSet <Funcionario> Funcionarios { get; set; }
        public DbSet <Cliente> Clientes { get; set; }
        public DbSet <Pet> Pets { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }

    }
}
