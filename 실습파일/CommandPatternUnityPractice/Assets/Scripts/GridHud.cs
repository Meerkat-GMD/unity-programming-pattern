using UnityEngine;

public sealed class GridHud : MonoBehaviour
{
    [SerializeField] private GridUnit unit;
    [SerializeField] private CommandHistory history;

    private void OnGUI()
    {
        if (unit == null || history == null)
        {
            return;
        }

        GUILayout.BeginArea(new Rect(16, 16, 360, 170), GUI.skin.box);
        GUILayout.Label("Command Pattern Practice");
        GUILayout.Space(6);
        GUILayout.Label($"Position: {unit.GridPosition}");
        GUILayout.Label($"History Count: {history.Count}");
        GUILayout.Label($"Current Index: {history.CurrentIndex}");
        GUILayout.Label($"Can Undo: {history.CanUndo}");
        GUILayout.Label($"Can Redo: {history.CanRedo}");
        GUILayout.Space(6);
        GUILayout.Label("Arrow: Move | Z: Undo | Y: Redo | R: Reset");
        GUILayout.EndArea();
    }
}
