//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblIlceler
    {
        public int id { get; set; }
        public string ilce { get; set; }
        public int sehir { get; set; }
    
        public virtual TblIller TblIller { get; set; }
    }
}
