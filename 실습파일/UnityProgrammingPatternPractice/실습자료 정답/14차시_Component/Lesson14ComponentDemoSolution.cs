// Teacher solution reference for 14차시 Component.
// Copy the relevant methods into Assets/Scripts/14차시_Component when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson14ComponentDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("컴포넌트 패턴 정답 예시");
        log.Add("Move, Health, RenderInfo 컴포넌트를 조합해 하나의 엔티티를 만든다.");
        log.Add("핵심 역할: Entity / Component / Composition / Decoupling / Message");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
