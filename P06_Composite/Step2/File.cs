namespace P06_Composite.Step2;

public class File : FileSystemNode
{
    public File(string path) 
        : base(path)
    {
    }

    public override int CountNumOfFiles()
    {
        return 1;
    }

    public override long CountSizeOfFiles()
    {
        FileInfo fileInfo = new FileInfo(_path);
        if (!fileInfo.Exists) return 0;
        return fileInfo.Length;
    }
}