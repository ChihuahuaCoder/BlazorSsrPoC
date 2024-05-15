using BlazorSsrPoC.Components.Features.ToDo.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorSsrPoC.Components.Models;

public class ApplicationDbContext : DbContext {
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    public DbSet<ToDoEntity> Todos { get; set; }
}
