using BlazorSsrPoC.Components.Models;

namespace BlazorSsrPoC.Components.Features.ToDo.Models;

public static class ToDoSeeder {
    public static void Initialize(ApplicationDbContext context) {
        var todos = new List<ToDoEntity> {
            new() {
                Id = Guid.NewGuid(),
                Title = "Blazor",
                IsDone = false
            },
            new() {
                Id = Guid.NewGuid(),
                Title = "Yoga",
                IsDone = false
            },
            new() {
                Id = Guid.NewGuid(),
                Title = "Progresownik",
                IsDone = false
            }
        };
        
        context.Todos.AddRange(todos);
        context.SaveChanges();
    }
}
