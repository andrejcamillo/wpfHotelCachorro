using HotelCachorro.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.DAL
{
    class ServicoDAO
    {

        private static Context ctx = SingletonContext.GetInstance();



        public static List<Servico> ListarServicos()
        {
            return ctx.Servicos.ToList();
        }

        public static Servico BuscarServicoPorNome(Servico s)
        {
            return ctx.Servicos.FirstOrDefault(x => x.NomeServico.Equals(s.NomeServico));
        }


        public static Servico BuscarServicoPorId(int servico)
        {
            return ctx.Servicos.FirstOrDefault(x => x.IdServico == servico);
        }


        public static Servico ValorServico(Servico s)
        {
            return ctx.Servicos.FirstOrDefault(x => x.PrecoServico == s.PrecoServico);
        }


        public static bool CadastrarServico(Servico s)
        {
            if (!string.IsNullOrEmpty(s.NomeServico) && s.PrecoServico > 0)
            {
                if (BuscarServicoPorNome(s) == null)
                {
                    ctx.Servicos.Add(s);
                    ctx.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }


        public static bool ExcluirServico(Servico s)
        {

            ctx.Servicos.Remove(s);
            ctx.SaveChanges();
            return true;

        }

        public static bool EditarServico(Servico s)
        {

            if (!string.IsNullOrEmpty(s.NomeServico) && s.PrecoServico > 0)
            {

                ctx.Entry(s).State = EntityState.Modified;
                ctx.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
