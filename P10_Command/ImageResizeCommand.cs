namespace P10_Command;

public class ImageResizeCommand : ICommand
{
    private readonly Guid _imageId;
    private readonly int _newWidthInPixel;
    private readonly int _newHeightInPixel;
    private readonly int _oldWidthInPixel;
    private readonly int _oldHeightInPixel;
    private readonly WordAutomation _wordAutomation;

    public ImageResizeCommand(Guid imageId, int newWidthInPixel, int newHeightInPixel,
        WordAutomation wordAutomation)
    {
        _imageId = imageId;
        _oldWidthInPixel = GetImageWidth(imageId);
        _oldHeightInPixel = GetImageHeight(imageId);


        _newWidthInPixel = newWidthInPixel;
        _newHeightInPixel = newHeightInPixel;
        _wordAutomation = wordAutomation;
    }

    private int GetImageWidth(Guid imageId)
    {
        return 800;
    }
    
    private int GetImageHeight(Guid imageId)
    {
        return 600;
    }

    public void Do()
    {
        _wordAutomation.ResizeImage(_imageId, _newWidthInPixel, _newHeightInPixel);
    }

    public void Undo()
    {
        _wordAutomation.ResizeImage(_imageId, _oldWidthInPixel, _oldHeightInPixel);
    }
}