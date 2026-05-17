// Teacher solution reference for 16차시 ServiceLocator.
// Copy the relevant methods into Assets/Scripts/16차시_ServiceLocator when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson16ServiceLocatorDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("서비스 로케이터 패턴 정답 예시");
        log.Add("AudioService를 등록하고 플레이 요청을 로케이터로 전달한다.");
        log.Add("핵심 역할: Service / Locator / Null Object / Register / Resolve");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
