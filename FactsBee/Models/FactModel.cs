namespace FactsBee.Models
{
    public class FactModel
    {
        public FactModel(int id, string categoryName, string _, string fact, string categoryImage)
        {
            Id = id;
            CategoryName = categoryName;
            CategoryImage = categoryImage;
            Fact = fact;
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryImage { get; set; }
        public string Fact { get; set; }

        
    }
}
