using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.Model
{
    [Table("Funcoes")]
    class Funcao
    {
        [Key]
        public int FuncaoId { get; set; }
        public string Nome { get; set; }
    }

}
