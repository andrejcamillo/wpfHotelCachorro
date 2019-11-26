using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.Model
{
    [Table("Servicos")]
    class Servico
    {
        [Key]
        public int IdServico { get; set; }
        public string NomeServico { get; set; }
        public double PrecoServico { get; set; }
    }
}
