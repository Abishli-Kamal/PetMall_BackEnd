using System.Collections.Generic;

namespace PetMall_Project.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Product>  Products { get; set; }
    }
}
