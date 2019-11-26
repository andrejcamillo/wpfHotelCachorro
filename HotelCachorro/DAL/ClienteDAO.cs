using HotelCachorro.Model;
using HotelCachorro.Utils;
using HotelCachorro.Views;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.DAL
{
    class ClienteDAO
    {


        private static Context ctx = SingletonContext.GetInstance();

        public static Cliente BuscarClientePorCPF(Cliente c)
        {
            return ctx.Clientes.FirstOrDefault(x => x.Cpf.Equals(c.Cpf));
        }

        
        public static Cliente BuscarClientePorId(string cpf)
        {
            return ctx.Clientes.FirstOrDefault(x => x.Cpf.Equals(cpf));
        }



        public static bool CadastrarCliente(Cliente c)
        {

          
           

            if (!string.IsNullOrEmpty(c.Nome) && !string.IsNullOrEmpty(c.Telefone) && !string.IsNullOrEmpty(c.Rg) && c.Genero!=null && !string.IsNullOrEmpty(c.Sobrenome))
            {
                if (Validacao.ValidarCpf(c.Cpf))
                {
                    if (BuscarClientePorCPF(c) == null)
                    {
                        ctx.Clientes.Add(c);
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

        public static bool ExcluirCliente(Cliente c)
        {
            c = BuscarClientePorCPF(c);
            if (c != null)
            {
                ctx.Clientes.Remove(c);
                ctx.SaveChanges();
                return true;

            }
            return false;
        }


        public static Cliente Lmmm(Cliente c) => ctx.Clientes.Include("Genero").ToList().FirstOrDefault(x => x.Cpf.Equals(c.Cpf));

        public static List<Cliente> ListarClientes() => ctx.Clientes.Include("Genero").ToList();


        public static bool EditarCliente(Cliente c)
        {

            //var entity = ctx.Clientes.Find(c.IdCliente);
            //Console.WriteLine(entity);
            Console.WriteLine(c);
    
            


            if (Validacao.ValidarCpf(c.Cpf))
            {
                

                    //ctx.Set<Cliente>().AddOrUpdate(c);
                    ctx.Entry(c).State = EntityState.Modified;
                    //ctx.Entry(c).CurrentValues.SetValues(c);
                    ctx.SaveChanges();
                    return true;
                
                
            }
            else
            {
                return false;
            }

        }

        public static Pet BuscarClientePorPet(Pet p)
        {
            return ctx.Pets.Include("Cliente").FirstOrDefault(
                x => x.Nome.Equals(p.Nome) && x.cliente.IdCliente == p.cliente.IdCliente
                );
        }

    }
    }

