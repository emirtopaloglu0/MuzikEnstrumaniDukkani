//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MuzikEnstrumaniDukkani.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Destek_Talepleri
    {
        public int Id { get; set; }
        public int Siparis_Id { get; set; }
        public int Destek_Kategori_Id { get; set; }
        public string Talep { get; set; }
        public string Admin_Cevap { get; set; }
        public bool Okundu { get; set; }
        public bool Isleme_Alindi { get; set; }
        public bool Tamamlandi { get; set; }
        public bool Aktif { get; set; }
        public System.DateTime Talep_Tarihi { get; set; }
    
        public virtual Destek_Kategorileri Destek_Kategorileri { get; set; }
        public virtual Siparisler Siparisler { get; set; }
    }
}
