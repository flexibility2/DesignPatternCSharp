namespace P10_Command;

public interface ICommand
{
    void Do();
    void Undo();
}