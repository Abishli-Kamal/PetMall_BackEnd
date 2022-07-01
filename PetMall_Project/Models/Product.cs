namespace PetMall_Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string MainImage { get; set; }
        public string AnotherImage { get; set; }
        public bool IsMain { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; } 
    }
}
