// Teacher solution reference for 9차시 GameLoop.
// Copy the relevant methods into Assets/Scripts/09차시_GameLoop when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson09GameLoopDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("게임 루프 패턴 정답 예시");
        log.Add("deltaTime을 사용해 같은 속도로 움직이는 미니 루프를 만든다.");
        log.Add("핵심 역할: Input / Update / Render / Delta Time / Fixed Step");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
