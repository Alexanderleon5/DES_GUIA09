﻿using LibroAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosAPI.Tests
{
    public static class Setup
    {
        public static LibroContext GetInMemoryDatabaseContext()
        {
            var options = new DbContextOptionsBuilder<LibroContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            var context = new LibroContext(options);
            context.Database.EnsureCreated();
            return context;
        }
    }
}
