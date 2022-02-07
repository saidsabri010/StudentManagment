using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManagment.Models;

namespace StudentManagment.Data
{
    public class StudentManagmentContext : DbContext
    {
        public StudentManagmentContext (DbContextOptions<StudentManagmentContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManagment.Models.Student> Student { get; set; }
    }
}
