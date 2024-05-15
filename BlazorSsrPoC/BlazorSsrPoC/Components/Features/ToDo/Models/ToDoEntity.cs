namespace BlazorSsrPoC.Components.Features.ToDo.Models;

public class ToDoEntity {
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
}
