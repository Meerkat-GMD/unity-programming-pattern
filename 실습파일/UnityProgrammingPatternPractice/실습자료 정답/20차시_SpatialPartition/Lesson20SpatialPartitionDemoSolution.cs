// Teacher solution reference for 20차시 SpatialPartition.
// Copy the relevant methods into Assets/Scripts/20차시_SpatialPartition when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson20SpatialPartitionDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("공간 분할 패턴 정답 예시");
        log.Add("유닛을 그리드 셀에 등록하고 주변 셀에서 가까운 유닛만 찾는다.");
        log.Add("핵심 역할: Grid / Cell / Insert / Move / Nearby Query");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
