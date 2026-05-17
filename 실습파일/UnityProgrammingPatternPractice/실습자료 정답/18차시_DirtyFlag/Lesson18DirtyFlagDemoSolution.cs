// Teacher solution reference for 18차시 DirtyFlag.
// Copy the relevant methods into Assets/Scripts/18차시_DirtyFlag when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson18DirtyFlagDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("더티 플래그 패턴 정답 예시");
        log.Add("로컬 좌표가 바뀌면 worldPosition을 dirty로 표시하고 필요할 때 계산한다.");
        log.Add("핵심 역할: Dirty / Cached Value / Lazy Update / Invalidation / Recalculate");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
