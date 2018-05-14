﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace InternetTechnology.Models
{
    public class InfoContext: DbContext
    {
        public InfoContext(DbContextOptions<InfoContext> options): base(options)
        {

        }
        public DbSet<Info> Info { get; set; }
    }
}