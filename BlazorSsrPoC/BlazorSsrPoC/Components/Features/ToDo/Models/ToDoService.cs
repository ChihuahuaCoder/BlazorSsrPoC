using Microsoft.AspNetCore.Components;

namespace BlazorSsrPoC.Components.Features.ToDo.Models;

public class ToDoService {
    private readonly HttpClient _client;

    public ToDoService(HttpClient client) {
        _client = client;
    }
    public async Task<ICollection<ToDoDto>?> GetTodoAsync() {
        return await _client.GetFromJsonAsync<List<ToDoDto>>( "http://localhost:5254/todos");
    }
}
