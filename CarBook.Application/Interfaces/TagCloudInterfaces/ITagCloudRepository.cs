﻿using CarBookDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces.TagCloudInterfaces
{
    public interface ITagCloudRepository
    {
        List<TagCloud> GetTadCloudsByBlogId(int id);
    }
}
