namespace P06_Composite.Step2;

public abstract class FileSystemNode
{
    protected readonly string _path;

    public FileSystemNode(string path)
    {
        _path = path;
    }

    public abstract int CountNumOfFiles();
    public abstract long CountSizeOfFiles();

    public string GetPath()
    {
        return _path;
    }
}