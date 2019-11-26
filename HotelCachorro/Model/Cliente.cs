using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.Model
{
    [Table("Clientes")]
    class Cliente : Pessoa
    {
        [Key]
        public int IdCliente { get; set; }

        public string Sobrenome { get; set; }
   
    }
}
