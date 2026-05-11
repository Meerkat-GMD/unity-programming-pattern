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
        before = unit.GridPosition;
        unit.MoveTo(destination);
    }

    public void Undo()
    {
        unit.MoveTo(before);
    }
}
