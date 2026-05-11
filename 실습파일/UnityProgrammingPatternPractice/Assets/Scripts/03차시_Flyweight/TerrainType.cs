using UnityEngine;

public sealed class TerrainType
{
    public string Name { get; }
    public int MovementCost { get; }
    public bool IsWater { get; }
    public Color Color { get; }

    public TerrainType(string name, int movementCost, bool isWater, Color color)
    {
        // TODO 1: Store terrain data in this shared flyweight object.
        // Assign all constructor parameters to the matching properties.
        Name = "TODO";
        MovementCost = 0;
        IsWater = false;
        Color = Color.magenta;
    }
}
