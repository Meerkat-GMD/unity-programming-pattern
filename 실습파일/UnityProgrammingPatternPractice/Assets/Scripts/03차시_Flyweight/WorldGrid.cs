using UnityEngine;

public sealed class WorldGrid
{
    private readonly int width;
    private readonly int height;
    private readonly TileInstance[,] tiles;

    private TerrainType grass;
    private TerrainType hill;
    private TerrainType river;

    public WorldGrid(int width, int height)
    {
        this.width = width;
        this.height = height;
        tiles = new TileInstance[width, height];
    }

    public void Generate()
    {
        CreateTerrainTypes();

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                // TODO 5: Choose a shared TerrainType reference for this tile.
                // Do not create a new TerrainType inside this loop.
                // Example idea: mostly grass, sometimes hill.
                TerrainType terrain = grass;
                tiles[x, y] = new TileInstance(new Vector2Int(x, y), terrain);
            }
        }

        int riverX = Random.Range(0, width);
        for (int y = 0; y < height; y++)
        {
            // TODO 6: Replace one column with river tiles that share the river object.
            tiles[riverX, y] = new TileInstance(new Vector2Int(riverX, y), grass);
        }
    }

    public TileInstance GetTile(int x, int y)
    {
        return tiles[x, y];
    }

    public bool AreSameTerrainReference(Vector2Int a, Vector2Int b)
    {
        return ReferenceEquals(tiles[a.x, a.y].Terrain, tiles[b.x, b.y].Terrain);
    }

    private void CreateTerrainTypes()
    {
        // TODO 3: Create one shared instance for each terrain type.
        // These objects contain intrinsic data shared by many tiles.
        grass = new TerrainType("Grass", 1, false, new Color(0.34f, 0.75f, 0.31f));

        // TODO 4: Create hill and river shared instances.
        // hill should be slower than grass.
        // river should have IsWater set to true.
        hill = grass;
        river = grass;
    }
}
