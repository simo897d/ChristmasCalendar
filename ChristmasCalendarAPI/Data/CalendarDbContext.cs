using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChristmasCalendarAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ChristmasCalendarAPI.Data
{
    public class CalendarDbContext : DbContext
    {
        public CalendarDbContext(DbContextOptions<CalendarDbContext> options) : base(options) {
            
        }
        public DbSet<Fact> Facts { get; set; }
    }
}
