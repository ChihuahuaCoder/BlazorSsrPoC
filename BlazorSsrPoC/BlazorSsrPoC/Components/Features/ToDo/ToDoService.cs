namespace BlazorSsrPoC.Components.Features.ToDo;

public class ToDoService {
    public Task<ICollection<ToDoElement>> GetTodoAsync() {
        var result = new List<ToDoElement> {
            new() { Title = "Blazor" },
            new() { Title = "Yoga" },
            new() { Title = "Progresownik" }
        };
        return Task.FromResult<ICollection<ToDoElement>>(result);
    }
}
