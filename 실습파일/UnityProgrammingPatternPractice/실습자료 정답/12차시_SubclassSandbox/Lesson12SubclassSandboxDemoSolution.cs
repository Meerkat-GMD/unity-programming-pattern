// Teacher solution reference for 12차시 SubclassSandbox.
// Copy the relevant methods into Assets/Scripts/12차시_SubclassSandbox when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson12SubclassSandboxDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("서브클래스 샌드박스 패턴 정답 예시");
        log.Add("PowerUp 하위 클래스가 보호 메서드만 사용해 효과를 만든다.");
        log.Add("핵심 역할: Base Class / Protected Helper / Sandbox / Subclass / Controlled Access");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
