using PetMall_Project.DAL;
using PetMall_Project.Models;
using System.Collections.Generic;

namespace PetMall_Project.View_Models
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<ProductCardOne> ProductCardOnes { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public List<Contact> Contacts { get; set; }

    }
}
