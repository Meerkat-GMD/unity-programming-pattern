using UnityEngine;

public readonly struct TileInstance
{
    public Vector2Int Position { get; }
    public TerrainType Terrain { get; }

    public TileInstance(Vector2Int position, TerrainType terrain)
    {
        // TODO 2: Store only extrinsic tile data here.
        // Position is unique per tile.
        // Terrain should be a reference to a shared TerrainType object.
        Position = Vector2Int.zero;
        Terrain = terrain;
    }
}
