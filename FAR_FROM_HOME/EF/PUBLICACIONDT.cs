//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FAR_FROM_HOME.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PUBLICACIONDT
    {
        public int ID_PUBLICACION { get; set; }
        public int ID_USUARIO { get; set; }
        public int ID_UBICACION { get; set; }
        public int ID_RAZA { get; set; }
        public string ESTADO_SALUD { get; set; }
        public string TIPO_MASCOTA { get; set; }
        public string COLOR_MASCOTA { get; set; }
        public string TAMAÑO { get; set; }
        public string EDAD { get; set; }
        public string REDES { get; set; }
        public string SEXO { get; set; }
        public string TRANSITO { get; set; }
        public string EST_ENCPERD { get; set; }
        public Nullable<System.TimeSpan> F_PUBLICACION { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual RAZADT RAZADT { get; set; }
        public virtual UBICACIONDT UBICACIONDT { get; set; }
        public virtual USUARIODT USUARIODT { get; set; }
    }
}