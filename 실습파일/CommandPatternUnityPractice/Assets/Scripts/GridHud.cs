using UnityEngine;

public sealed class GridHud : MonoBehaviour
{
    [SerializeField] private GridUnit unit;
    [SerializeField] private CommandHistory history;

    private GUIStyle titleStyle;
    private GUIStyle labelStyle;
    private GUIStyle smallStyle;
    private GUIStyle cellStyle;

    private void OnGUI()
    {
        if (unit == null || history == null)
        {
            return;
        }

        EnsureStyles();

        Rect screen = new Rect(0f, 0f, Screen.width, Screen.height);
        DrawRect(screen, new Color(0.08f, 0.09f, 0.11f));

        float margin = Mathf.Max(24f, Screen.width * 0.025f);
        Rect panel = new Rect(margin, margin, Screen.width * 0.34f, Screen.height - margin * 2f);
        Rect board = new Rect(panel.xMax + margin, margin, Screen.width - panel.width - margin * 3f, Screen.height - margin * 2f);

        DrawPanel(panel);
        DrawBoard(board);
    }

    private void DrawPanel(Rect rect)
    {
        DrawRect(rect, new Color(0.15f, 0.16f, 0.20f));

        float x = rect.x + 28f;
        float y = rect.y + 28f;
        float width = rect.width - 56f;

        GUI.Label(new Rect(x, y, width, 70f), "Command Pattern", titleStyle);
        y += 88f;

        GUI.Label(new Rect(x, y, width, 44f), $"Position: {unit.GridPosition}", labelStyle);
        y += 52f;
        GUI.Label(new Rect(x, y, width, 44f), $"History Count: {history.Count}", labelStyle);
        y += 52f;
        GUI.Label(new Rect(x, y, width, 44f), $"Current Index: {history.CurrentIndex}", labelStyle);
        y += 72f;

        GUI.Label(new Rect(x, y, width, 44f), $"Undo: {(history.CanUndo ? "READY" : "EMPTY")}", labelStyle);
        y += 52f;
        GUI.Label(new Rect(x, y, width, 44f), $"Redo: {(history.CanRedo ? "READY" : "EMPTY")}", labelStyle);
        y += 80f;

        GUI.Label(new Rect(x, y, width, 120f), "Arrow Keys: Move\nZ: Undo\nY: Redo\nR: Reset", smallStyle);
    }

    private void DrawBoard(Rect rect)
    {
        DrawRect(rect, new Color(0.11f, 0.12f, 0.15f));

        int range = 4;
        int cells = range * 2 + 1;
        float size = Mathf.Min(rect.width, rect.height) * 0.9f;
        float cell = size / cells;
        float startX = rect.center.x - size * 0.5f;
        float startY = rect.center.y - size * 0.5f;

        Vector2Int center = unit.GridPosition;

        for (int y = range; y >= -range; y--)
        {
            for (int x = -range; x <= range; x++)
            {
                Vector2Int grid = new Vector2Int(center.x + x, center.y + y);
                Rect cellRect = new Rect(startX + (x + range) * cell, startY + (range - y) * cell, cell - 4f, cell - 4f);

                bool isUnit = grid == unit.GridPosition;
                DrawRect(cellRect, isUnit ? new Color(0.95f, 0.72f, 0.23f) : new Color(0.24f, 0.27f, 0.33f));

                GUI.Label(cellRect, isUnit ? "UNIT" : $"{grid.x},{grid.y}", cellStyle);
            }
        }
    }

    private void EnsureStyles()
    {
        int large = Mathf.Clamp(Screen.height / 16, 32, 64);
        int normal = Mathf.Clamp(Screen.height / 24, 24, 44);
        int small = Mathf.Clamp(Screen.height / 32, 18, 34);

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

        cellStyle ??= new GUIStyle(GUI.skin.label)
        {
            alignment = TextAnchor.MiddleCenter,
            fontSize = small,
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
