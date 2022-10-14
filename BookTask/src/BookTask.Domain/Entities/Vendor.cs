using BookTask.Domain.Common;

namespace BookTask.Domain.Entities;

public class Vendor : BaseEntity
{
    public Vendor()
    {
        Books = new HashSet<Book>();
    }
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }
}
