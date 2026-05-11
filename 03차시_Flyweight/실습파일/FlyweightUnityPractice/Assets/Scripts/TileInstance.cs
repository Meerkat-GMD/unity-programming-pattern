using UnityEngine;

public readonly struct TileInstance
{
    public Vector2Int Position { get; }
    public TerrainType Terrain { get; }

    public TileInstance(Vector2Int position, TerrainType terrain)
    {
        Position = position;
        Terrain = terrain;
    }
}
