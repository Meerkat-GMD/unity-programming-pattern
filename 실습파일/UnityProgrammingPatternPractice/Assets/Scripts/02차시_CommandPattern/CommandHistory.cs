using System.Collections.Generic;
using UnityEngine;

public sealed class CommandHistory : MonoBehaviour
{
    private readonly List<IUndoableCommand> commands = new();
    private int currentIndex = -1;

    public int Count => commands.Count;
    public int CurrentIndex => currentIndex;
    public bool CanUndo => currentIndex >= 0;
    public bool CanRedo => currentIndex + 1 < commands.Count;

    public void Execute(IUndoableCommand command)
    {
        if (command == null)
        {
            return;
        }

        int redoCount = commands.Count - currentIndex - 1;
        if (redoCount > 0)
        {
            commands.RemoveRange(currentIndex + 1, redoCount);
        }

        commands.Add(command);
        currentIndex++;
        command.Execute();
    }

    public void Undo()
    {
        if (!CanUndo)
        {
            return;
        }

        commands[currentIndex].Undo();
        currentIndex--;
    }

    public void Redo()
    {
        if (!CanRedo)
        {
            return;
        }

        currentIndex++;
        commands[currentIndex].Execute();
    }

    public void Clear()
    {
        commands.Clear();
        currentIndex = -1;
    }
}
