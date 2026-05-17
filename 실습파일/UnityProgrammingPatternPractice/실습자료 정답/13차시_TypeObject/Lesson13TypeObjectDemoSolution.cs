// Teacher solution reference for 13차시 TypeObject.
// Copy the relevant methods into Assets/Scripts/13차시_TypeObject when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson13TypeObjectDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("타입 오브젝트 패턴 정답 예시");
        log.Add("Monster가 Breed 데이터를 참조해 능력치를 결정하게 만든다.");
        log.Add("핵심 역할: Type Object / Breed / Data-Driven / Instance / Runtime Type");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
