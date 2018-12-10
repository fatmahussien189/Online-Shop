using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJECT.ADV.Models
{
    public class product
{
    public int productId { get; set; }
    public string name { get; set; }
    public string Description { get; set; }
    public decimal price { get; set; }
    public string ImageUrl { get; set; }
    public string ImageThumbnailUrl { get; set; }
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }
}
}
