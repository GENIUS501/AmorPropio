//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tab_Bitacora_Sesiones
    {
        public int codigo_ingreso_salida { get; set; }
        public System.DateTime fecha_hora_ingreso { get; set; }
        public Nullable<System.DateTime> fecha_hora_salida { get; set; }
        public Nullable<int> Id_Usuario { get; set; }
    
        public virtual Tab_Usuarios Tab_Usuarios { get; set; }
    }
}
