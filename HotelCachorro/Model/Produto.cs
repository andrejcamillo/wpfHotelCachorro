using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.Model
{
    [Table("Produtos")]
    class Produto
    {
       [Key]
       public int IdProduto { get; set; }
       public string NomeProduto { get; set; }
       public double PrecoProduto { get; set; }
    }
}
