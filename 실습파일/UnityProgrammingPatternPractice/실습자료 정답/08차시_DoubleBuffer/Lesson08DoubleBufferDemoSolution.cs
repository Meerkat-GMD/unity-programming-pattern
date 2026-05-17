// Teacher solution reference for 8차시 DoubleBuffer.
// Copy the relevant methods into Assets/Scripts/08차시_DoubleBuffer when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson08DoubleBufferDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("더블 버퍼 패턴 정답 예시");
        log.Add("격자의 다음 세대를 nextBuffer에 계산한 뒤 swap한다.");
        log.Add("핵심 역할: Current Buffer / Next Buffer / Swap / Frame Boundary / Consistency");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
