using HotelCachorro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.DAL
{
    class ItensDAO
    {

        private static Context ctx = SingletonContext.GetInstance();

        public static List<ItemVenda> ProdutosPorCliente(Reserva r)
        {
            return ctx.ItensVenda.Where(x => x.Reserva.IdReserva == r.IdReserva).ToList();
        }

        public static List<ItemVenda> ProdutosPorClienteXX(int valor)
        {
            return ctx.ItensVenda.Include("Produto").Include("Servico").Where(x => x.Reserva.IdReserva == valor).ToList();
        }

        
        public static bool RemoverVendaPorId(int reserva)
        {
 
            IEnumerable<ItemVenda> list = ctx.ItensVenda.Where(c => c.Reserva.IdReserva == reserva).ToList();
            ctx.ItensVenda.RemoveRange(list);
            ctx.SaveChanges();
            return true;

        }



    }
}
