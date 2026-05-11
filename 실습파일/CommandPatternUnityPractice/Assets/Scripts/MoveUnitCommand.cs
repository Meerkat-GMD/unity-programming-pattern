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
        // TODO 1: 이동하기 전에 unit.GridPosition을 before에 저장하세요.
        // TODO 2: unit.MoveTo(destination)을 호출하세요.
    }

    public void Undo()
    {
        // TODO 3: unit.MoveTo(before)을 호출해 이전 좌표로 되돌리세요.
    }
}
