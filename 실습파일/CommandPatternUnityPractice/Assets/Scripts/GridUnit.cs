using UnityEngine;

public sealed class GridUnit : MonoBehaviour
{
    [SerializeField] private Vector2Int gridPosition;
    [SerializeField] private float cellSize = 1f;

    public Vector2Int GridPosition => gridPosition;

    private void Start()
    {
        ApplyWorldPosition();
    }

    public void MoveTo(Vector2Int nextPosition)
    {
        gridPosition = nextPosition;
        ApplyWorldPosition();
    }

    public void ResetToOrigin()
    {
        MoveTo(Vector2Int.zero);
    }

    private void ApplyWorldPosition()
    {
        transform.position = new Vector3(gridPosition.x * cellSize, gridPosition.y * cellSize, 0f);
    }
}
