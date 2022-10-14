using BookTask.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask.Domain.Entities;

public class Review : BaseEntity
{
    public int Star { get; set; }
    public Comment Comment { get; set; }
}
