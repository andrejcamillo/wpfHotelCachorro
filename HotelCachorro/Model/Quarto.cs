using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.Model
{
    [Table("Quartos")]
    class Quarto
    {
        [Key]
        public int IdQuarto{ get; set; }
        public string NomeQuarto { get; set; }
        public double PrecoQuarto { get; set; }

    

    }
}
