//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPIParcial
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class transaccion
    {

        public int Id { get; set; }
        public int usuario { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal monto { get; set; }
    
        public virtual usuario usuario1 { get; set; }
    }
}