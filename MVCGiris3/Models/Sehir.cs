using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCGiris3.Models
{
    [Table("Sehirler")]
    public class Sehir
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "İl Kodu")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Şehir Adı")]
        [StringLength(50, ErrorMessage = "Şehir adı 50 karakteri geçemez.")]

        public string SehirAd { get; set; }

        public virtual ICollection<Kisi> Kisiler { get; set; }
    }
}