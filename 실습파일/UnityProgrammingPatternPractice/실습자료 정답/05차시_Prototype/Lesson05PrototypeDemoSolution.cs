// Teacher solution reference for 5차시 Prototype.
// Copy the relevant methods into Assets/Scripts/05차시_Prototype when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson05PrototypeDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("프로토타입 패턴 정답 예시");
        log.Add("몬스터 원형 데이터를 복제해 서로 다른 몬스터 인스턴스를 만든다.");
        log.Add("핵심 역할: Prototype / Clone / Prefab / Template / Deep Copy");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
