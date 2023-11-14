using BlazorConversion.Data;

namespace BlazorConversion.Services
{
    public interface ILibrary
    {
        public List<User> Users { get; set; }
        public List<Book> Books { get; set; }
        public Dictionary<User, List<Book>> borrowedBooks { get; set; }
    }
}
