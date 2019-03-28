using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HTML_Helpers.Models
    
{


    public class Empleado
    {
        [Required(ErrorMessage = "Campo obligatorio")]
        public String Nombre { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public String Apellido { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        public String Cedula { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")]
        [Range(15, 100, ErrorMessage = "Debes ser mayor a 15!")]
        public int Edad { get; set; }

        public String Telefono { get; set; }

        
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Dirección de Correo electrónico incorrecta.")]
        public String Correo { get; set; }

        public String Genero { get; set; }

        public String EstadoCivil { get; set; }

        public bool Programar { get; set; }
        public bool Dibujar { get; set; }
        public bool Jugar { get; set; }
        public bool Chatear { get; set; }

    }
  
    public enum Genero
    {
        Masculino,
        Femenino
    }

}