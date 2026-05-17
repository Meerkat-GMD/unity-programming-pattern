// Teacher solution reference for 4차시 Observer.
// Copy the relevant methods into Assets/Scripts/04차시_Observer when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson04ObserverDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("옵저버 패턴 정답 예시");
        log.Add("플레이어 점수가 바뀌면 HUD와 업적 시스템이 동시에 갱신되게 만든다.");
        log.Add("핵심 역할: Subject / Observer / Notify / Subscribe / Unsubscribe");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
