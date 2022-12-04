using System.Security.Cryptography;
using JACT.FastCopier.Models;

namespace JACT.FastCopier;

public class Copier
{
    private string _left;
    private string _right;
    private CopyType _type;

    private List<IndexedFile> _leftFiles;
    private List<IndexedFile> _rightFiles;
    

    public Copier(string left, string right, CopyType type)
    {
        _left = left;
        _right = right;
        _type = type;
        _leftFiles = new List<IndexedFile>();
        _rightFiles = new List<IndexedFile>();
    }

    public async Task Prepare()
    {
        Index(_left, _leftFiles);
        Index(_right, _rightFiles);
    }

    private async Task Index(string path, List<IndexedFile> indexList)
    {
        string[] items = Directory.GetFileSystemEntries(path);
        foreach (var item in items)
        {
            FileAttributes attr = File.GetAttributes(item);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                // Path is a directory
            }
            if ((attr & FileAttributes.Normal) == FileAttributes.Normal)
            {
                // Path is a file
                string hashString;

                using (SHA1 sha1 = SHA1.Create())
                {
                    using (var stream = File.OpenRead(item))
                    {
                        byte[] hash = await sha1.ComputeHashAsync(stream);
                        hashString = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                        IndexedFile f = new IndexedFile()
                        {
                            FileName = item,
                            Created = File.GetCreationTimeUtc(item),
                            Updated = File.GetLastWriteTimeUtc(item),
                            Hash = hashString
                        };
                    }
                }
                
                
            }
        }
        
    }

}