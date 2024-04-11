namespace P10_Command;

public class UndoStack
{
    private readonly Stack<ICommand> _innerStack;
    private RedoStack _redoStack;

    public UndoStack(int maxUndoSteps)
    {
        _innerStack = new Stack<ICommand>(maxUndoSteps);
    }

    public void SetRedoStack(RedoStack redoStack)
    {
        _redoStack = redoStack;
    }

    public void PushCommand(ICommand command)
    {
        _innerStack.Push(command);
    }
    
    public void RedoLastCommand()
    {
        var command = _innerStack.Pop();
        command.Do();
        
        _redoStack.PushCommand(command);
    }
}