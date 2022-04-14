using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_App.Models
{
    public class ProductMetadata
    {
        public long ProductID { get; set; }

        [Required(ErrorMessage = "Please enter Product name.")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Price")]
        public Nullable<decimal> Price { get; set; }

        [Display(Name = "Date Of Purchase")]
        public Nullable<System.DateTime> DateOfPurchase { get; set; }
        [Required(ErrorMessage = "Please enter dop.")]


        [Display(Name = "Availability Status")]
        public string AvailabilityStatus { get; set; }
        [Required(ErrorMessage = "Please enter Availability Status")]

        [Display(Name = "Category")]
        public Nullable<long> CategoryID { get; set; }
        [Required(ErrorMessage = "Please enter Category.")]

        [Display(Name = "Brand")]
        public Nullable<long> BrandID { get; set; }
        [Required]
        public Nullable<bool> Active { get; set; }
        
        public string Photo { get; set; }
        [Required]

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
    }
}