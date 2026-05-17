// Teacher solution reference for 19차시 ObjectPool.
// Copy the relevant methods into Assets/Scripts/19차시_ObjectPool when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson19ObjectPoolDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("오브젝트 풀 패턴 정답 예시");
        log.Add("ProjectilePool에서 총알을 빌리고 일정 시간 뒤 반환한다.");
        log.Add("핵심 역할: Pool / Get / Release / Reset / Capacity");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
