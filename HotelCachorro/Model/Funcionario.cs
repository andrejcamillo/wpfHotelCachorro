using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.Model
{

    [Table("Funcionario")]
    class Funcionario : Pessoa
    {

        [Key]
        public int Matricula { get; set; }

        public Funcao Funcao { get; set; }

    }
}
