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

        // TODO 4: If there are redo commands after currentIndex, remove them.
        // Hint:
        // int redoCount = commands.Count - currentIndex - 1;
        // commands.RemoveRange(currentIndex + 1, redoCount);

        // TODO 5: Add the new command to commands and increase currentIndex.

        // TODO 6: Execute the command.
    }

    public void Undo()
    {
        // TODO 7: If there is no command to undo, return.

        // TODO 8: Undo the current command, then decrease currentIndex.
    }

    public void Redo()
    {
        // TODO 9: If there is no command to redo, return.

        // TODO 10: Increase currentIndex, then execute that command again.
    }

    public void Clear()
    {
        commands.Clear();
        currentIndex = -1;
    }
}
