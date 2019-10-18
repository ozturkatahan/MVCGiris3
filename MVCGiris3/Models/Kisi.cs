using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCGiris3.Models
{
    [Table("Kisiler")]
    public class Kisi
    {
        public int Id { get; set; }

        [Display(Name = "İsim")]
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        [StringLength(30, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
        public string Ad { get; set; }

        [Display(Name = "Soyisim")]
        [StringLength(30, ErrorMessage = "{0} {1} karakterden uzun olamaz")]
        
        public string Soyad { get; set; }

        [Display(Name = "Doğum Yeri")]
        [ForeignKey("DogumYeri")]
        public int? DogumYeriId { get; set; }

        public virtual Sehir DogumYeri { get; set; }

    }
}