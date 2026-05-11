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
                TerrainType terrain = Random.value < 0.15f ? hill : grass;
                tiles[x, y] = new TileInstance(new Vector2Int(x, y), terrain);
            }
        }

        int riverX = Random.Range(0, width);
        for (int y = 0; y < height; y++)
        {
            tiles[riverX, y] = new TileInstance(new Vector2Int(riverX, y), river);
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
        grass = new TerrainType("Grass", 1, false, new Color(0.34f, 0.75f, 0.31f));
        hill = new TerrainType("Hill", 3, false, new Color(0.55f, 0.48f, 0.34f));
        river = new TerrainType("River", 2, true, new Color(0.20f, 0.50f, 0.95f));
    }
}
