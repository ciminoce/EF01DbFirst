//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF01DbFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curso
    {
        public int CursoId { get; set; }
        public string NombreCurso { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public byte Vacantes { get; set; }
    }
}