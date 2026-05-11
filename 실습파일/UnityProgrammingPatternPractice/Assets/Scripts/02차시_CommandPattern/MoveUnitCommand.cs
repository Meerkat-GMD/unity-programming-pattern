using UnityEngine;

public sealed class MoveUnitCommand : IUndoableCommand
{
    private readonly GridUnit unit;
    private readonly Vector2Int destination;
    private Vector2Int before;

    public MoveUnitCommand(GridUnit unit, Vector2Int destination)
    {
        this.unit = unit;
        this.destination = destination;
    }

    public void Execute()
    {
        // TODO 1: Move before changing position.
        // Save the current position into the before field.

        // TODO 2: Move the unit to destination.
        // Hint: call unit.MoveTo(destination).
    }

    public void Undo()
    {
        // TODO 3: Move the unit back to the saved before position.
    }
}
