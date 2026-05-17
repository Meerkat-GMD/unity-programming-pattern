// Teacher solution reference for 6차시 Singleton.
// Copy the relevant methods into Assets/Scripts/06차시_Singleton when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson06SingletonDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("싱글턴 패턴 정답 예시");
        log.Add("GameSettings 싱글턴을 만들고, 과도한 전역 접근의 문제를 로그로 확인한다.");
        log.Add("핵심 역할: Single Instance / Global Access / Initialization Order / Hidden Dependency / Alternative");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
