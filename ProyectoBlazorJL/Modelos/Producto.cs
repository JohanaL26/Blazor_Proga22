using System.ComponentModel.DataAnnotations;

namespace Modelos;

public class Producto
    {
        [Required(ErrorMessage = "El campo Codigo es obligatroio")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo Descripcion es obligatroio")]
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Existencia { get; set; }
        public byte[] Imagen { get; set; }

    }

