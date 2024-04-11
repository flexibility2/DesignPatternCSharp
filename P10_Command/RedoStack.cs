namespace P10_Command;

public class RedoStack
{
    private readonly Stack<ICommand> _innerStack;
    private UndoStack _undoStack;
    
    public RedoStack(int maxUndoSteps)
    {
        _innerStack = new Stack<ICommand>(maxUndoSteps);
    }

    public void SetUndoStack(UndoStack undoStack)
    {
        _undoStack = undoStack;
    }

    public void PushCommand(ICommand command)
    {
        _innerStack.Push(command);
    }

    public void UndoLastCommand()
    {
        var command = _innerStack.Pop();
        command.Undo();
        
        _undoStack.PushCommand(command);
    }
}