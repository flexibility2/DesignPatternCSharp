namespace P10_Command;

public class WordAutomation
{
    public void PutText(int row, int column, string text)
    {
        Console.WriteLine($"Put text:'{text}' on ({row}, {column})");
    }

    public void RemoveText(int row, int column, string text)
    {
        Console.WriteLine($"Remove text:'{text}' from ({row}, {column})");
    }

    public void ResizeImage(Guid imageId, int newWidthInPixel, int newHeightInPixel)
    {
        Console.WriteLine($"Resize image(id:{imageId}) to new size (w:{newWidthInPixel}, h:{newHeightInPixel})");
    }
}