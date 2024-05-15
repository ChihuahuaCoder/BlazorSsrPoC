using BlazorSsrPoC.Components.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorSsrPoC.Components.Features.ToDo.Controllers;

[Route("todos")]
[ApiController]
public class ToDosControllers : Controller {
    private readonly ApplicationDbContext _db;

    public ToDosControllers(ApplicationDbContext db) {
        _db = db;
    }

    [HttpGet]
    public async Task<List<ToDoDto>> GetToDos() {
        return await _db.Todos
            .Select(e => e.ToDto())
            .ToListAsync();
    }
}
