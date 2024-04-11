namespace P10_Command;

public class TextInputCommand : ICommand
{
    private readonly int _row;
    private readonly int _col;
    private readonly string _text;
    private readonly WordAutomation _wordAutomation;

    public TextInputCommand(int row, int col, string text,
        WordAutomation wordAutomation)
    {
        _row = row;
        _col = col;
        _text = text;
        _wordAutomation = wordAutomation;
    }

    public void Do()
    {
        _wordAutomation.PutText(_row, _col, _text);
    }

    public void Undo()
    {
        _wordAutomation.RemoveText(_row, _col, _text);
    }
}