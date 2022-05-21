using Day45Demo.EntityFrameworkAsyncAwaitDemo.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Day45Demo.EntityFrameworkAsyncAwaitDemo;

public static class EfCoreTest
{
    public static void Test()
    {
        using var context = new SampleStoreContext();

        var categories = context.Categories.ToList();

        foreach (var category in categories)
        {
            Console.WriteLine($"{category.CategoryId}, {category.CategoryName}");
        }

    }

    public static async Task TestAsync()
    {
        using var context = new SampleStoreContext();

        //var categoriesTask = context.Categories.ToListAsync();
        //var categories = await categoriesTask;

        var categories = await context.Categories.ToListAsync();

        foreach (var category in categories)
        {
            Console.WriteLine($"{category.CategoryId}, {category.CategoryName}");
        }
    }
}
