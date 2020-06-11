using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeDataLibrary.BikeStoresData;

namespace BikeDataLibrary.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product name:")]
        [StringLength(255)]
        public string ProductName { get; set; }
        [Required]
        [Display(Name = "Brand:")]
        public int BrandId { get; set; }
        [Required]
        [Display(Name = "Category:")]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name = "Model year:")]
        public short ModelYear { get; set; }
        [Required]
        [Display(Name = "List price:")]
        public decimal ListPrice { get; set; }


        public brand Brand { get; set; }
        public category Category { get; set; }
    }
}
