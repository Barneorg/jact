namespace JACT.FastCopier.Models;

public class IndexedFile
{
    public string FileName { get; set; }
    public DateTime Updated { get; set; }
    public DateTime Created { get; set; }
    public string Hash { get; set; }
}