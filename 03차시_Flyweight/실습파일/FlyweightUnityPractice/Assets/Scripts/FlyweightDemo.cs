using UnityEngine;

public sealed class FlyweightDemo : MonoBehaviour
{
    [SerializeField] private int width = 10;
    [SerializeField] private int height = 8;

    private void Start()
    {
        WorldGrid world = new WorldGrid(width, height);
        world.Generate();

        TileInstance first = world.GetTile(0, 0);
        Debug.Log($"Tile {first.Position}: {first.Terrain.Name}, cost={first.Terrain.MovementCost}, water={first.Terrain.IsWater}");

        TileInstance second = world.GetTile(1, 0);
        Debug.Log($"Tile {second.Position}: {second.Terrain.Name}, cost={second.Terrain.MovementCost}, water={second.Terrain.IsWater}");

        bool sameReference = world.AreSameTerrainReference(first.Position, second.Position);
        Debug.Log($"Same TerrainType reference? {sameReference}");
    }
}
