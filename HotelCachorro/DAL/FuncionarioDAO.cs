using HotelCachorro.Model;
using HotelCachorro.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.DAL
{
    class FuncionarioDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static Funcionario BuscarFuncionarioPorCPF(Funcionario f)
        {
            return ctx.Funcionarios.FirstOrDefault(x => x.Cpf.Equals(f.Cpf));
        }


        public static Funcionario BuscarFuncionarioPorId(string cpf)
        {
            return ctx.Funcionarios.FirstOrDefault(x => x.Cpf.Equals(cpf));
        }


        public static Cliente BuscarPessoaPorCPF(Funcionario f)
        {
            return ctx.Clientes.FirstOrDefault(x => x.Cpf.Equals(f.Cpf));
        }

        public static bool CadastrarFuncionario(Funcionario f)
        {


            if (!string.IsNullOrEmpty(f.Nome) && !string.IsNullOrEmpty(f.Telefone) && !string.IsNullOrEmpty(f.Rg) && f.Genero != null && f.Funcao !=null)
            {
                if (Validacao.ValidarCpf(f.Cpf))
                {
                    if (BuscarPessoaPorCPF(f) == null)
                    {
                        ctx.Funcionarios.Add(f);
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
            else
            {
                return false;
            }
        }

        public static bool ExcluirFuncionario(Funcionario f)
        {
            f = BuscarFuncionarioPorCPF(f);
            if (f != null)
            {
                ctx.Funcionarios.Remove(f);
                ctx.SaveChanges();
                return true;

            }
            return false;
        }


        public static Funcionario Lmmm(Funcionario f) => ctx.Funcionarios.Include("Genero").Include("Funcao").ToList()
            .FirstOrDefault(x => x.Cpf.Equals(f.Cpf));

        public static List<Funcionario> ListarFuncionarios() => ctx.Funcionarios.Include("Genero").Include("Funcao").ToList();


        public static bool EditarFuncionario(Funcionario f)
        {

            if (Validacao.ValidarCpf(f.Cpf))
            {

                ctx.Entry(f).State = EntityState.Modified;
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
