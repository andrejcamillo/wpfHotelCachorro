using HotelCachorro.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.DAL
{
    class ProdutoDAO
    {

        private static Context ctx = SingletonContext.GetInstance();



        public static List<Produto> ListarProdutos()
        {
            return ctx.Produtos.ToList();
        }

        public static Produto BuscarProdutoPorNome(Produto p)
        {
            return ctx.Produtos.FirstOrDefault(x => x.NomeProduto.Equals(p.NomeProduto));
        }


        public static Produto BuscarProdutoPorId(int produto)
        {
            return ctx.Produtos.FirstOrDefault(x => x.IdProduto == produto);
        }


        public static Produto ValorProduto(Produto p)
        {
            return ctx.Produtos.FirstOrDefault(x => x.PrecoProduto == p.PrecoProduto);
        }


        public static bool CadastrarProduto(Produto p)
        {
            if (!string.IsNullOrEmpty(p.NomeProduto) && p.PrecoProduto > 0)
            {
                if (BuscarProdutoPorNome(p) == null)
                {
                    ctx.Produtos.Add(p);
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


        public static bool ExcluirProduto(Produto p)
        {

            ctx.Produtos.Remove(p);
            ctx.SaveChanges();
            return true;

        }

        public static bool EditarProduto(Produto p)
        {

            if (!string.IsNullOrEmpty(p.NomeProduto) && p.PrecoProduto > 0)
            {

                ctx.Entry(p).State = EntityState.Modified;
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
