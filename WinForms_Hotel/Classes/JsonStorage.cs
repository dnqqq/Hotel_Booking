using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using WinForms_Hotel.Classes;
using WinForms_Hotel.Interfaces;
public class JsonStorage<T> : IDataStorage<T> where T : BaseEntity
{
    private readonly string _filePath;
    private List<T> _items;
    public JsonStorage(string filePath)
    {
        _filePath = filePath;
        _items = LoadFromFile();
    }
    public List<T> LoadFromFile()
    {
        if (!File.Exists(_filePath) || new FileInfo(_filePath).Length == 0)
            return new List<T>();  // Якщо файл порожній або не існує

        var json = File.ReadAllText(_filePath);

        // Якщо файл порожній повертаємо порожній список
        if (string.IsNullOrWhiteSpace(json))
            return new List<T>();

        try
        {
            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }
        catch (JsonException)
        {
            // Якщо JSON некоректний, повертаємо порожній список
            return new List<T>();
        }
    }


    public void Add(T entity)
    {
        _items.Add(entity);
    }
    public void Update(T entity)
    {
        var index = _items.FindIndex(e => e.Id == entity.Id);
        if (index != -1)
        {
            _items[index] = entity;
        }
    }
    public void Delete(int id)
    {
        var item = _items.FirstOrDefault(e => e.Id == id);
        if (item != null)
        {
            _items.Remove(item);
        }
    }
    public T? GetById(int id)
    {
        return _items.FirstOrDefault(e => e.Id == id);
    }
    public List<T> GetAll()
    {
        return _items;
    }
    public void Save()
    {
        var json = JsonSerializer.Serialize(_items, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        File.WriteAllText(_filePath, json);
    }

}
