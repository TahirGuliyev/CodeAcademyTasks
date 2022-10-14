using BookTask.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask.Domain.Entities;

public class Book : BaseEntity
{
    public Book()
    { 
        Review = new HashSet<Review>();
    }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Format { get; set; }
    public string Description { get; set; }
    public string Language { get; set; }
    public string Type { get; set; }
    public ICollection<Review> Review { get; set; }
}
