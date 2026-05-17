using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson19ObjectPoolDemo : MonoBehaviour
{
    private readonly List<string> log = new();
    private GUIStyle titleStyle;
    private GUIStyle bodyStyle;

    private void Start()
    {
        log.Add("19차시 ObjectPool 실습");
        log.Add("TODO를 채우면 이 화면의 결과가 바뀝니다.");
        RunPractice();
    }

    private void RunPractice()
    {
        // TODO 1: 초기 풀 생성
        // TODO 2: Get
        // TODO 3: Release
        // TODO 4: ResetState
        // TODO 5: 풀 고갈 처리
        log.Add("현재 상태: 아직 핵심 구현이 비어 있습니다.");
    }

    private void OnGUI()
    {
        EnsureStyles();
        DrawRect(new Rect(0, 0, Screen.width, Screen.height), new Color(0.08f, 0.09f, 0.11f));
        GUI.Label(new Rect(36, 30, Screen.width - 72, 70), "19차시 ObjectPool Pattern", titleStyle);
        GUI.Label(new Rect(44, 120, Screen.width - 88, Screen.height - 150), string.Join("\n\n", log), bodyStyle);
    }

    private void EnsureStyles()
    {
        titleStyle ??= new GUIStyle(GUI.skin.label)
        {
            fontSize = Mathf.Clamp(Screen.height / 14, 34, 72),
            fontStyle = FontStyle.Bold,
            normal = { textColor = Color.white }
        };
        bodyStyle ??= new GUIStyle(GUI.skin.label)
        {
            fontSize = Mathf.Clamp(Screen.height / 24, 24, 44),
            normal = { textColor = new Color(0.88f, 0.94f, 1f) },
            wordWrap = true
        };
    }

    private static void DrawRect(Rect rect, Color color)
    {
        Color old = GUI.color;
        GUI.color = color;
        GUI.DrawTexture(rect, Texture2D.whiteTexture);
        GUI.color = old;
    }
}
