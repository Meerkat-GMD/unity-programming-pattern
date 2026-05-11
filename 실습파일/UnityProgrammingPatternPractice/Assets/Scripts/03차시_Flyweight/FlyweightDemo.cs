using UnityEngine;

public sealed class FlyweightDemo : MonoBehaviour
{
    [SerializeField] private int width = 10;
    [SerializeField] private int height = 8;

    private WorldGrid world;
    private TileInstance firstSharedTile;
    private TileInstance secondSharedTile;
    private bool sameReference;

    private GUIStyle titleStyle;
    private GUIStyle labelStyle;
    private GUIStyle smallStyle;
    private GUIStyle tileStyle;

    private void Start()
    {
        world = new WorldGrid(width, height);
        world.Generate();

        PickSharedTerrainPair();

        Debug.Log($"Tile {firstSharedTile.Position}: {firstSharedTile.Terrain.Name}, cost={firstSharedTile.Terrain.MovementCost}, water={firstSharedTile.Terrain.IsWater}");
        Debug.Log($"Tile {secondSharedTile.Position}: {secondSharedTile.Terrain.Name}, cost={secondSharedTile.Terrain.MovementCost}, water={secondSharedTile.Terrain.IsWater}");
        Debug.Log($"Same TerrainType reference? {sameReference}");
    }

    private void OnGUI()
    {
        if (world == null)
        {
            return;
        }

        EnsureStyles();

        Rect screen = new Rect(0f, 0f, Screen.width, Screen.height);
        DrawRect(screen, new Color(0.08f, 0.09f, 0.11f));

        float margin = Mathf.Max(24f, Screen.width * 0.025f);
        Rect board = new Rect(margin, margin, Screen.width * 0.62f, Screen.height - margin * 2f);
        Rect panel = new Rect(board.xMax + margin, margin, Screen.width - board.width - margin * 3f, Screen.height - margin * 2f);

        DrawTileMap(board);
        DrawInfoPanel(panel);
    }

    private void DrawTileMap(Rect rect)
    {
        DrawRect(rect, new Color(0.12f, 0.13f, 0.16f));

        float mapSize = Mathf.Min(rect.width * 0.92f, rect.height * 0.86f);
        float cell = mapSize / Mathf.Max(width, height);
        float startX = rect.center.x - width * cell * 0.5f;
        float startY = rect.center.y - height * cell * 0.5f;

        GUI.Label(new Rect(rect.x + 28f, rect.y + 18f, rect.width - 56f, 60f), "Flyweight Terrain Map", titleStyle);

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                TileInstance tile = world.GetTile(x, y);
                Rect tileRect = new Rect(startX + x * cell, startY + y * cell + 34f, cell - 4f, cell - 4f);

                DrawRect(tileRect, tile.Terrain.Color);
                GUI.Label(tileRect, tile.Terrain.Name.Substring(0, 1), tileStyle);
            }
        }
    }

    private void DrawInfoPanel(Rect rect)
    {
        DrawRect(rect, new Color(0.15f, 0.16f, 0.20f));

        float x = rect.x + 28f;
        float y = rect.y + 28f;
        float width = rect.width - 56f;

        GUI.Label(new Rect(x, y, width, 70f), "Shared Data", titleStyle);
        y += 94f;

        GUI.Label(new Rect(x, y, width, 48f), $"Tile A: {firstSharedTile.Position}", labelStyle);
        y += 50f;
        GUI.Label(new Rect(x, y, width, 48f), $"Tile B: {secondSharedTile.Position}", labelStyle);
        y += 66f;

        TerrainType terrain = firstSharedTile.Terrain;
        GUI.Label(new Rect(x, y, width, 48f), $"Terrain: {terrain.Name}", labelStyle);
        y += 50f;
        GUI.Label(new Rect(x, y, width, 48f), $"Move Cost: {terrain.MovementCost}", labelStyle);
        y += 50f;
        GUI.Label(new Rect(x, y, width, 48f), $"Water: {terrain.IsWater}", labelStyle);
        y += 72f;

        string result = sameReference ? "SAME INSTANCE" : "DIFFERENT";
        GUI.Label(new Rect(x, y, width, 68f), $"Reference: {result}", labelStyle);
        y += 86f;

        GUI.Label(new Rect(x, y, width, 150f), "Many tiles keep only position.\nTerrain data is shared by reference.\nThat shared object is the flyweight.", smallStyle);
    }

    private void PickSharedTerrainPair()
    {
        firstSharedTile = world.GetTile(0, 0);
        secondSharedTile = world.GetTile(0, 0);

        for (int ay = 0; ay < height; ay++)
        {
            for (int ax = 0; ax < width; ax++)
            {
                TileInstance a = world.GetTile(ax, ay);

                for (int by = ay; by < height; by++)
                {
                    for (int bx = 0; bx < width; bx++)
                    {
                        if (ax == bx && ay == by)
                        {
                            continue;
                        }

                        TileInstance b = world.GetTile(bx, by);
                        if (ReferenceEquals(a.Terrain, b.Terrain))
                        {
                            firstSharedTile = a;
                            secondSharedTile = b;
                            sameReference = true;
                            return;
                        }
                    }
                }
            }
        }
    }

    private void EnsureStyles()
    {
        int large = Mathf.Clamp(Screen.height / 17, 30, 62);
        int normal = Mathf.Clamp(Screen.height / 25, 24, 42);
        int small = Mathf.Clamp(Screen.height / 34, 18, 32);

        titleStyle ??= new GUIStyle(GUI.skin.label)
        {
            fontSize = large,
            fontStyle = FontStyle.Bold,
            normal = { textColor = Color.white }
        };

        labelStyle ??= new GUIStyle(GUI.skin.label)
        {
            fontSize = normal,
            fontStyle = FontStyle.Bold,
            normal = { textColor = Color.white }
        };

        smallStyle ??= new GUIStyle(GUI.skin.label)
        {
            fontSize = small,
            normal = { textColor = new Color(0.86f, 0.90f, 0.96f) }
        };

        tileStyle ??= new GUIStyle(GUI.skin.label)
        {
            alignment = TextAnchor.MiddleCenter,
            fontSize = normal,
            fontStyle = FontStyle.Bold,
            normal = { textColor = Color.white }
        };
    }

    private static void DrawRect(Rect rect, Color color)
    {
        Color previous = GUI.color;
        GUI.color = color;
        GUI.DrawTexture(rect, Texture2D.whiteTexture);
        GUI.color = previous;
    }
}
