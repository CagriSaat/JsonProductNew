using System.Collections.Generic;

namespace JsonProduct.Models
{
    public class ProductModel
    {
        public int Id { get; set; } 
        public string Title { get; set; }    
        public string Description { get; set; }
        public decimal Price { get; set; }
        public float discountPercentage { get; set; }
        public float rating { get; set;}
        public int stock { get; set; }
        public string brand  { get; set;}
        public string category { get; set; }
        public string thumbnail { get; set; }   
        public string images { get; set; }
          
    }
}
