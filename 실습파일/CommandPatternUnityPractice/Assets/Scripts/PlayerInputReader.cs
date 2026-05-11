using UnityEngine;

public sealed class PlayerInputReader : MonoBehaviour
{
    [SerializeField] private GridUnit unit;
    [SerializeField] private CommandHistory history;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            history.Undo();
            return;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            history.Redo();
            return;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            unit.ResetToOrigin();
            history.Clear();
            return;
        }

        IUndoableCommand command = ReadMoveCommand();
        if (command != null)
        {
            history.Execute(command);
        }
    }

    private IUndoableCommand ReadMoveCommand()
    {
        Vector2Int direction = Vector2Int.zero;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2Int.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2Int.down;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2Int.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2Int.right;
        }

        if (direction == Vector2Int.zero)
        {
            return null;
        }

        Vector2Int destination = unit.GridPosition + direction;
        return new MoveUnitCommand(unit, destination);
    }
}
