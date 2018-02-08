using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace _60322_Ivanov_Egor.DAL.Entities
{
    public class Product
    {
        [Key]
        [HiddenInput]
        public int ProdId { get; set; }
        [Required(ErrorMessage = "Введите название")]
        [Display(Name = "Название")]
        public string ProdName { get; set; }
        [Required]
        [Display(Name = "Группа")]
        public string ProdCategory { get; set; }
        [Required(ErrorMessage = "Введите описание")]
        [Display(Name = "Описание")]
        public string ProdDescription { get; set; }
        [Required]
        [Range(minimum:0.01,maximum:1000000)]
        [Display(Name = "Цена")]
        public decimal ProdPrice { get; set; }
        [ScaffoldColumn(false)]
        public byte[] ProdImage { get; set; }
        [ScaffoldColumn(false)]
        public string MimeType { get; set; }
    }
}
