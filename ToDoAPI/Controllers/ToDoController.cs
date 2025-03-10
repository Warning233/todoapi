using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoAPI.Data;
using ToDoAPI.Models;

namespace ToDoAPI.Controllers;

[Route("api/todo")]
[ApiController]
public class ToDoController : ControllerBase
{
    private readonly AppDbContext _context;

    public ToDoController(AppDbContext context)
    {
        _context = context;
    }
    
    // Get all tasks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<ToDoItem>>> GetToDoItems()
    {
        return await _context.ToDoItems.ToListAsync();
    }
    
    // Get task by ID
    [HttpGet("{id}")]
    public async Task<ActionResult<ToDoItem>> GetToDoItem(int id)
    {
        var item = await _context.ToDoItems.FindAsync(id);

        if (item == null) return NotFound();
        
        return item;
    }
    
    // Create a new task 
    [HttpPost]
    public async Task<ActionResult<ToDoItem>> CreateToDoItem(ToDoItem item)
    {
        _context.ToDoItems.Add(item);
        await _context.SaveChangesAsync();
        
        return CreatedAtAction(nameof(GetToDoItem), new { id = item.Id }, item);
    }
    
    // Update task
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateToDoItem(int id, ToDoItem item)
    {
        if (id != item.Id) return BadRequest();
        
        _context.Entry(item).State = EntityState.Modified;
        await _context.SaveChangesAsync();
        
        return NoContent();
    }
    
    // Delete task
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteToDoItem(int id)
    {
        var item = await _context.ToDoItems.FindAsync(id);
        
        if (item == null) return NotFound();
        
        _context.ToDoItems.Remove(item);
        await _context.SaveChangesAsync();
        
        return NoContent();
    }
}