namespace BlazorSsrPoC.Components.Features.ToDo.Models;

public class ToDoService {
    public Task<ICollection<ToDoDto>> GetTodoAsync() {
        var result = new List<ToDoDto> {
            new() { Title = "Blazor" },
            new() { Title = "Yoga" },
            new() { Title = "Progresownik" }
        };
        return Task.FromResult<ICollection<ToDoDto>>(result);
    }
}
