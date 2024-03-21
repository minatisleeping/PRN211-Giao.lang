using System;
using System.Collections.Generic;

namespace Repositories.Entities;

public partial class BookCategory
{
    public int BookCategoryId { get; set; }

    public string BookGenreType { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
