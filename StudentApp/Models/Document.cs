using System;
using System.Collections.Generic;

namespace StudentApp.Models;

public partial class Document
{
    public int DocId { get; set; }

    public int DocCategoryId { get; set; }

    public string Title { get; set; } = null!;

    public string Descriptions { get; set; } = null!;

    public virtual DocumentCategory DocCategory { get; set; } = null!;
}
