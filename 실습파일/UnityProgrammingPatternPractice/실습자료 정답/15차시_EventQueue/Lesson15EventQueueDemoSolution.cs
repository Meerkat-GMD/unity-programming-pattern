// Teacher solution reference for 15차시 EventQueue.
// Copy the relevant methods into Assets/Scripts/15차시_EventQueue when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson15EventQueueDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("이벤트 큐 패턴 정답 예시");
        log.Add("여러 사운드 요청을 큐에 넣고 한 프레임 끝에서 처리한다.");
        log.Add("핵심 역할: Queue / Enqueue / Process Later / Temporal Decoupling / Batch");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
