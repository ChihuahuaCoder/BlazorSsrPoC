using BlazorSsrPoC.Components.Features.ToDo.Models;

namespace BlazorSsrPoC.Components.Features.ToDo;

public static class ToDoMapper {
    public static ToDoDto ToDto(this ToDoEntity entity) {
        return new ToDoDto {
            Title = entity.Title,
            IsDone = entity.IsDone
        };
    }
}
