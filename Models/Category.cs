namespace Modi_Naomi_Lab2.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public ICollection<Book>? Books { get; set; }
    }
}
