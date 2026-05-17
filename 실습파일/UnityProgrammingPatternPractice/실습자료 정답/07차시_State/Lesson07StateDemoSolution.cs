// Teacher solution reference for 7차시 State.
// Copy the relevant methods into Assets/Scripts/07차시_State when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson07StateDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("상태 패턴 정답 예시");
        log.Add("플레이어 상태를 Standing, Jumping, Ducking으로 분리한다.");
        log.Add("핵심 역할: FSM / State Object / Transition / Enter / Exit");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
