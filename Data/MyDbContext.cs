using EF_D1.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EF_D1.Data;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) 
    {

    }
    public virtual DbSet<Student>? Students {get; set;}
}