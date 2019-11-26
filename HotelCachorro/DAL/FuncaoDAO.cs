using HotelCachorro.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.DAL
{
    class FuncaoDAO
    {

        private static Context ctx = SingletonContext.GetInstance();


        public static List<Funcao> ListarFuncoes()
        {
            return ctx.Funcoes.ToList();
        }

        public static Funcao BuscarFuncaoPorId(int funcao)
        {
            return ctx.Funcoes.FirstOrDefault(x => x.FuncaoId == funcao);
        }

    }
}
