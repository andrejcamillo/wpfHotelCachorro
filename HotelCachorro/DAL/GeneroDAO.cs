using HotelCachorro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.DAL
{
    class GeneroDAO
    {
        private static Context ctx = SingletonContext.GetInstance();


        public static List<Genero> ListarProdutos()
        {
            return ctx.Generos.ToList();
        }

        public static Genero BuscarGeneroPorId(int genero)
        {
            return ctx.Generos.FirstOrDefault(x => x.GeneroId == genero);
        }
    }
}
