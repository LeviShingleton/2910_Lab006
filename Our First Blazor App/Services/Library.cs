using BlazorConversion.Data;

namespace BlazorConversion.Services
{
    public class Library : ILibrary
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<Book> Books { get; set; } = new List<Book>();
        public Dictionary<User, List<Book>> borrowedBooks { get; set ; } = new Dictionary<User, List<Book>>();
    }
}
