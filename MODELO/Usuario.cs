//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODELO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string email { get; set; }
        public string contraseña { get; set; }
        public string telefono { get; set; }
        public bool activo { get; set; }
        public int id_tipo { get; set; }
    
        public virtual TipoUsuario TipoUsuario { get; set; }
    }
}