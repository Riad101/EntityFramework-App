using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_App.Models
{

    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {
    }
}