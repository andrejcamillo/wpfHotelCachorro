using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.Model
{

   
    class Pessoa
    {

    
        public string Nome { get; set; }
        public Genero Genero { get; set; }
        public DateTime? DataNascimento { get; set; }

        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
       




        public DateTime CriadoEm { get; set; }

        public Pessoa()
        {
            CriadoEm = DateTime.Now;
        }

    }
}
