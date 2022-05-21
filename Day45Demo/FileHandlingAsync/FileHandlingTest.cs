namespace Day45Demo.FileHandlingAsync;

public static class FileHandlingTest
{
    public static async Task TestAsync()
    {
        var fileManager = new MyFileManager(@"C:\logs\test\poetry.txt");
        var count = await fileManager.CountCharactersAsync();

        var fileTextPreSort = await fileManager.GetAllTextAsync();

        await fileManager.SortAsync();

        var fileTextPostSort = await fileManager.GetAllTextAsync();

        Console.WriteLine($"Count = {count}\n");
        Console.WriteLine($"Before Sort");
        Console.WriteLine($"-----------");
        Console.WriteLine($"{fileTextPreSort}\n");
        Console.WriteLine($"After Sort");
        Console.WriteLine($"-----------");
        Console.WriteLine($"{fileTextPostSort}\n");
    }

    public static void Test()
    {
        var fileManager = new MyFileManager(@"C:\logs\test\poetry.txt");
        var count = fileManager.CountCharacters();

        var fileTextPreSort = fileManager.GetAllText();

        fileManager.Sort();

        var fileTextPostSort = fileManager.GetAllText();

        Console.WriteLine($"Count = {count}\n");
        Console.WriteLine($"Before Sort");
        Console.WriteLine($"-----------");
        Console.WriteLine($"{fileTextPreSort}\n");
        Console.WriteLine($"After Sort");
        Console.WriteLine($"-----------");
        Console.WriteLine($"{fileTextPostSort}\n");
    }
}
