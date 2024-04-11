namespace P06_Composite.Step2;

public class Directory : FileSystemNode
{
    private readonly List<FileSystemNode> _subNodes = new List<FileSystemNode>();
    
    public Directory(string path) 
        : base(path)
    {
    }

    public override int CountNumOfFiles()
    {
        int numOfFiles = 0;
        foreach (FileSystemNode fileOrDir in _subNodes)
        {
            numOfFiles += fileOrDir.CountNumOfFiles();
        }
        return numOfFiles;
    }

    public override long CountSizeOfFiles()
    {
        long sizeOfFiles = 0;
        foreach (FileSystemNode fileOrDir in _subNodes)
        {
            sizeOfFiles += fileOrDir.CountSizeOfFiles();
        }
        return sizeOfFiles;
    }
    
    public void AddSubNode(FileSystemNode fileOrDir)
    {
        _subNodes.Add(fileOrDir);
    }

    public void RemoveSubNode(FileSystemNode fileOrDir)
    {
        FileSystemNode nodeToRemove = _subNodes.Find(node =>
            string.Equals(node.GetPath(), fileOrDir.GetPath(), StringComparison.OrdinalIgnoreCase));
        if (nodeToRemove != null)
        {
            _subNodes.Remove(nodeToRemove);
        }
    }
}