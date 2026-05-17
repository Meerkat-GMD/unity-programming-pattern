using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson06SingletonDemo : MonoBehaviour
{
    private readonly List<string> log = new();
    private GUIStyle titleStyle;
    private GUIStyle bodyStyle;

    private void Start()
    {
        log.Add("6차시 Singleton 실습");
        log.Add("TODO를 채우면 이 화면의 결과가 바뀝니다.");
        RunPractice();
    }

    private void RunPractice()
    {
        // TODO 1: Instance 보관
        // TODO 2: 중복 인스턴스 처리
        // TODO 3: 설정 값 읽기
        // TODO 4: 씬 재시작 시 유지 여부 선택
        // TODO 5: 대안 메서드 작성
        log.Add("현재 상태: 아직 핵심 구현이 비어 있습니다.");
    }

    private void OnGUI()
    {
        EnsureStyles();
        DrawRect(new Rect(0, 0, Screen.width, Screen.height), new Color(0.08f, 0.09f, 0.11f));
        GUI.Label(new Rect(36, 30, Screen.width - 72, 70), "6차시 Singleton Pattern", titleStyle);
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
