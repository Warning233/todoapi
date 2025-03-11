using System.Net.Http.Json;
using ToDoBlazor.Models;

namespace ToDoBlazor.Services;

public class ToDoService
{
    private readonly HttpClient _http;
    
    public ToDoService(HttpClient http)
    {
        _http = http;
    }
    
    public async Task<ToDoItem[]> GetItemsAsync()
    {
        return await _http.GetFromJsonAsync<ToDoItem[]>("api/todo") ?? Array.Empty<ToDoItem>();
    }
    
    public async Task AddItemAsync(ToDoItem item)
    {
        await _http.PostAsJsonAsync("api/todo", item);
    }
    
    public async Task UpdateItemAsync(ToDoItem item)
    {
        await _http.PutAsJsonAsync($"api/todo/{item.Id}", item);
    }
    
    public async Task DeleteItemAsync(int id)
    {
        await _http.DeleteAsync($"api/todo/{id}");
    }
}