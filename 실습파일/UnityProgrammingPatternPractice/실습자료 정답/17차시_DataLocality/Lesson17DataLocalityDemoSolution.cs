// Teacher solution reference for 17차시 DataLocality.
// Copy the relevant methods into Assets/Scripts/17차시_DataLocality when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson17DataLocalityDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("데이터 지역성 패턴 정답 예시");
        log.Add("Enemy 객체 리스트 대신 위치/속도 배열을 갱신한다.");
        log.Add("핵심 역할: Cache / Array / Hot Data / Cold Data / Batch");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
