using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Productos.Api.Models
{

    public class Productos
    {

        [Key]
        public string id { get; set; }
        [Required]
        [Column(TypeName = "varchar(250)")]
        public string descripcion { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]

        public string nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]

        public string color { get; set; }
        [Required]
        [Column(TypeName = "varchar(70)")]

        public string medidas { get; set; }

        [Required]
        [Column(TypeName = "bigint")]
        public int precio { get; set; }
        [Required]
        [Column(TypeName = "varchar(300)")]

        public string imagen { get; set; }

    }

}