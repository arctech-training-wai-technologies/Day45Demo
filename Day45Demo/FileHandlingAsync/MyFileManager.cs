namespace Day45Demo.FileHandlingAsync;

public class MyFileManager
{
    private string _filePath;

    public MyFileManager(string filePath)
    {
        _filePath = filePath;
    }

    public int CountCharacters()
    {
        var data = File.ReadAllText(_filePath);
        return data.Length;
    }

    public async Task<int> CountCharactersAsync()
    {
        var data = await File.ReadAllTextAsync(_filePath);
        return data.Length;
    }

    public string GetAllText()
    {
        var data = File.ReadAllText(_filePath);
        return data;
    }

    public async Task<string> GetAllTextAsync()
    {
        var data = await File.ReadAllTextAsync(_filePath);
        return data;
    }

    public void Sort()
    {
        var lines = File.ReadAllLines(_filePath);

        var linesList = lines.ToList();
        linesList.Sort();

        File.WriteAllLines(_filePath, linesList);
    }

    public async Task SortAsync()
    {
        var lines = await File.ReadAllLinesAsync(_filePath);

        var linesList = lines.ToList();
        linesList.Sort();

        await File.WriteAllLinesAsync(_filePath, linesList);
    }
}
