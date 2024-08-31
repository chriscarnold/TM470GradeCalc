using Microsoft.EntityFrameworkCore;
using TM470GradeCalc.Models;

namespace TM470GradeCalc.Data
{
    public class TM470Context : DbContext
    {
        public TM470Context(DbContextOptions<TM470Context> options) : base(options) { }

        public DbSet<TM470GradeCalc.Models.GradeCalc> TM470Grades { get; set; }
    }
}

