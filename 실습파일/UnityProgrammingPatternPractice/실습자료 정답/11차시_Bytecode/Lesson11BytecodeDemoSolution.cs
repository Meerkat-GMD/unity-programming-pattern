// Teacher solution reference for 11차시 Bytecode.
// Copy the relevant methods into Assets/Scripts/11차시_Bytecode when reviewing answers.
using System.Collections.Generic;
using UnityEngine;

public sealed class Lesson11BytecodeDemoSolution : MonoBehaviour
{
    private readonly List<string> log = new();

    private void Start()
    {
        log.Add("바이트코드 패턴 정답 예시");
        log.Add("간단한 Spell VM에서 PUSH, ADD, DAMAGE 명령을 실행한다.");
        log.Add("핵심 역할: Instruction / VM / Stack / Interpreter / Scripted Behavior");
        log.Add("정답 구현은 수업 중 학생 TODO와 비교하며 설명하세요.");
    }
}
