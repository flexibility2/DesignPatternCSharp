namespace P06_Composite.Step1;

public class FileSystemNode
{
    private readonly string _path;
    private readonly bool _isFile;
    private readonly List<FileSystemNode> _subNodes = new List<FileSystemNode>();

    public FileSystemNode(string path, bool isFile)
    {
        _path = path;
        _isFile = isFile;
    }

    public int CountNumOfFiles()
    {
        int count = 0;

        foreach (var node in _subNodes)
        {
            if (node._isFile)
            {
                count++;
            }
            else
            {
                count += node.CountNumOfFiles(); // 递归统计子目录中的文件数量
            }
        }

        return count;
    }

    public long CountSizeOfFiles()
    {
        long size = 0;

        foreach (var node in _subNodes)
        {
            if (node._isFile)
            {
                size += GetFileSize(node);
            }
            else
            {
                size += node.CountSizeOfFiles(); // 递归统计子目录中的文件大小
            }
        }

        return size;
    }

    private long GetFileSize(FileSystemNode node)
    {
        var fileInfo = new FileInfo(node._path);
        if (!fileInfo.Exists) return 0;
        return fileInfo.Length;
    }

    public string GetPath()
    {
        return _path;
    }

    public void AddSubNode(FileSystemNode fileOrDir)
    {
        _subNodes.Add(fileOrDir);
    }

    public void RemoveSubNode(FileSystemNode fileOrDir)
    {
        FileSystemNode nodeToRemove = _subNodes.FirstOrDefault(node => 
            node.GetPath().Equals(fileOrDir.GetPath(), StringComparison.OrdinalIgnoreCase));
        
        if (nodeToRemove != null)
        {
            _subNodes.Remove(nodeToRemove);
        }
    }
}
