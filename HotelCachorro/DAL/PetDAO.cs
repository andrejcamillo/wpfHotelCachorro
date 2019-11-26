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
    class PetDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        
        public static List<Pet> ListarPetPorCliente(int id)
        {
            return ctx.Pets.Include("Cliente").Where(x => x.cliente.IdCliente == id).ToList();
        }

        public static Pet BuscarPetPorId(int pet)
        {
            return ctx.Pets.FirstOrDefault(x => x.IdPet == pet);
        }


        public static Pet BuscarPetPorCliente(Pet p)
        {
            return ctx.Pets.Include("Cliente").FirstOrDefault(
                x => x.Nome.Equals(p.Nome) && x.cliente.IdCliente==p.cliente.IdCliente
                );    
        }

        public static Pet BuscarPetPorNome(Pet p)
        {
            return ctx.Pets.FirstOrDefault(x => x.Nome.Equals(p.Nome));
        }

        public static bool CadastrarPet(Pet p)
        {
          
                if (BuscarPetPorCliente(p) == null)
                {
                    ctx.Pets.Add(p);
                    ctx.SaveChanges();
                    return true;
                }

                return false;
         }


        public static List<Pet> ListarPets() => ctx.Pets.Include("Cliente").Include("Genero").ToList();

        //public static List<Pet> ListarPetsPorClienteXX(Reserva r) => ctx.Pets.Include("Cliente").Include("Genero").Where(x => x.cliente.IdCliente == r.Pet.cliente.IdCliente).ToList();


        public static bool ExcluirPet(Pet p)
        {
            //p = BuscarPetPorId(p.IdPet);
            p = BuscarPetPorNome(p);
           

            ctx.Pets.Remove(p);
            ctx.SaveChanges();
            return true;
            
        }


        public static bool EditarPet(Pet p)
        {

        
            if (Validacao.ValidarCpf(p.cliente.Cpf))
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

        public static Pet BuscarPetPorClienteXX(Pet p)
        {
            return ctx.Pets.Include("Cliente").FirstOrDefault(x => x.IdPet == p.IdPet);   
        }

    }
    }
