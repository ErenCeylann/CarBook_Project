﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookDomain.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public string Mail { get; set; }
        public int BlogId { get; set; }

        public Blog Blog { get; set; }
    }
}
