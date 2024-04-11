using P10_Command;

namespace P10_CommandTests;

public class CommandTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestUndoRedoCommand()
    {
        int maxUndoSteps = 10;
        
        var redoStack = new RedoStack(maxUndoSteps);
        var undoStack = new UndoStack(maxUndoSteps);
        
        redoStack.SetUndoStack(undoStack);
        undoStack.SetRedoStack(redoStack);

        WordAutomation wordAutomation = new WordAutomation();
        
        // Command 1: Put text
        var textInputCommand = new TextInputCommand(3, 20, "Hello", wordAutomation);
        textInputCommand.Do();
        redoStack.PushCommand(textInputCommand);
        
        // Command 2: Resize image
        var imageId = new Guid();
        var imageResizeCommand = new ImageResizeCommand(imageId, 640, 480, wordAutomation);
        imageResizeCommand.Do();
        redoStack.PushCommand(imageResizeCommand);
        
        // Command 3: Delete text
        var textDeleteCommand = new TextDeleteCommand(4, 3, "World", wordAutomation);
        textInputCommand.Do();
        redoStack.PushCommand(textInputCommand);
        
        redoStack.UndoLastCommand();    // Undo delete text
        redoStack.UndoLastCommand();    // Undo resize image
        undoStack.RedoLastCommand();    // Redo resize image
        redoStack.UndoLastCommand();    // Undo resize image
        redoStack.UndoLastCommand();    // Undo put text
    }
}