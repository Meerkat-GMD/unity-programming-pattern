using UnityEngine;

public sealed class TerrainType
{
    public string Name { get; }
    public int MovementCost { get; }
    public bool IsWater { get; }
    public Color Color { get; }

    public TerrainType(string name, int movementCost, bool isWater, Color color)
    {
        Name = name;
        MovementCost = movementCost;
        IsWater = isWater;
        Color = color;
    }
}
