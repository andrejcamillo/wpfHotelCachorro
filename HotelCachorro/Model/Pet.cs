
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelCachorro.Model
{
    [Table("Pet")]
    class Pet
    {
        [Key]
        public int IdPet { get; set; }

        public string Nome { get; set;}

        public Cliente cliente { get; set; }

        public Genero Genero { get; set; }

        public string Raca { get; set; }

        public string Castragem { get; set; }

        public string Pelagem { get; set; }

        public int Idade { get; set; }

        public string Porte { get; set; }

        public double Peso { get; set; }
     

        /*
        public string Raca { get; set; }
        public bool Castrado{ get; set; }
        public string Pelagem { get; set; }
        public string HistoricoVeterinario { get; set; }
        public int Idade { get; set; }
        public string Porte { get; set; }
        public double Peso { get; set; }
        */
    }
}
