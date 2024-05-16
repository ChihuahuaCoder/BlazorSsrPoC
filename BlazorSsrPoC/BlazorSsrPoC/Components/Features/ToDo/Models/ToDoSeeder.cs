using BlazorSsrPoC.Components.Models;

namespace BlazorSsrPoC.Components.Features.ToDo.Models;

public static class ToDoSeeder {
    public static void Initialize(ApplicationDbContext context) {
        var todos = new List<ToDoEntity> {
            new() {
                Id = Guid.NewGuid(),
                Title = "Blazor",
                IsCompleted = false
            },
            new() {
                Id = Guid.NewGuid(),
                Title = "Yoga",
                IsCompleted = false
            },
            new() {
                Id = Guid.NewGuid(),
                Title = "Progresownik",
                IsCompleted = false
            }
        };
        
        context.Todos.AddRange(todos);
        context.SaveChanges();
    }
}
