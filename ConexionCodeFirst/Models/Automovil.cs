using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConexionCodeFirst.Models
{
    public class Automovil
    {
        [Key]
        public int Id { get; set; }
        public string Modelo { get; set; }

        public string Marca { get; set; }

        public DateTime Year { get; set; }

        public string Color { get; set; }

        public string Cilindrada { get; set; }

        public string Traccion { get; set; }

        public string Combustible { get; set; }
    }
}