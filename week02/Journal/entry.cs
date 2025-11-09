public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public List<string> Tags { get; set; }

    public Entry(string prompt, string response, string date, List<string> tags)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
        Tags = tags;
    }

    public override string ToString()
    {
        string tagString = string.Join(", ", Tags);
        return $"{Date} | {Prompt} | {Response} | Tags: {tagString}";
    }
}
