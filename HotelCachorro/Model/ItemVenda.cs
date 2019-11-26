using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.Model
{
    [Table("ItensVendas")]
    class ItemVenda
    {
        [Key]
        public int IdVenda { get; set; }

        public Servico Servico { get; set; }
        public Produto Produto { get; set; }
        
        public string Nome {get; set;}
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Reserva Reserva { get; set; }
    }
}
