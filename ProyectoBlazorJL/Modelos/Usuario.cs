using System.ComponentModel.DataAnnotations;

namespace Modelos;


    public class Usuario
    {
        [Required(ErrorMessage = "El campo Código es obligatroio")]
            public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatroio")]
            public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo Rol es obligatroio")]
            public string Rol { get; set; }
        //[Required(ErrorMessage = "El campo Codigo es obligatroio")]
            public string Clave { get; set; }
            public bool EstaActivo { get; set; }

}
