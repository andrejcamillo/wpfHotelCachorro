using HotelCachorro.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.DAL
{
    class QuartoDAO
    {

        private static Context ctx = SingletonContext.GetInstance();



        public static List<Quarto> ListarQuartos()
        {
            return ctx.Quartos.ToList();
        }

        public static Quarto BuscarQuartoPorNome(Quarto q)
        {
            return ctx.Quartos.FirstOrDefault(x => x.NomeQuarto.Equals(q.NomeQuarto));
        }


        public static Quarto BuscarQuartoPorId(int quarto)
        {
            return ctx.Quartos.FirstOrDefault(x => x.IdQuarto == quarto);
        }

        public static List<Quarto> BuscarQuarto(Quarto q)
        {
            return ctx.Quartos.Where(x => x.IdQuarto == q.IdQuarto).ToList();  
        }

        public static Quarto ValorQuarto(Quarto q)
        {
            return ctx.Quartos.FirstOrDefault(x => x.PrecoQuarto == q.PrecoQuarto);
        }


        public static bool CadastrarQuarto(Quarto q)
        {
            if (!string.IsNullOrEmpty(q.NomeQuarto)  && q.PrecoQuarto>0)
            {
                    if (BuscarQuartoPorNome(q) == null)
                    {
                        ctx.Quartos.Add(q);
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


        public static bool ExcluirQuarto(Quarto q)
        {
            
            ctx.Quartos.Remove(q);
            ctx.SaveChanges();
            return true;

        }

        public static bool EditarQuarto(Quarto q)
        {
            
            if (!string.IsNullOrEmpty(q.NomeQuarto) && q.PrecoQuarto > 0)
            {
                
                ctx.Entry(q).State = EntityState.Modified;
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


