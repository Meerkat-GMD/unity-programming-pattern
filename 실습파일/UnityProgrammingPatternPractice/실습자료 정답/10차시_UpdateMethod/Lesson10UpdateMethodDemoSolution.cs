// Teacher solution reference for 10차시 UpdateMethod.
// Copy the relevant methods into Assets/Scripts/10차시_UpdateMethod when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson10UpdateMethodDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("업데이트 메서드 패턴 정답 예시");
        log.Add("여러 Actor의 Tick을 중앙 GameTicker가 호출하게 만든다.");
        log.Add("핵심 역할: Update / Actor List / Tick / Order / Deferred Removal");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
