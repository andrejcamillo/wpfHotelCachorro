using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.Model
{
    [Table("Generos")]
    class Genero
    {
        [Key]
        public int GeneroId { get; set; }
        public string Nome { get; set; }

        //public List<Pessoa> Pessoas { get; set; }
    }
}
