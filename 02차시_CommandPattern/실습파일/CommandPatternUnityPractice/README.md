# Command Pattern Unity Practice

Game Programming Patterns의 Command Pattern을 Unity/C#으로 실습하는 프로젝트입니다.

## 바로 실행하기

1. Unity Hub를 엽니다.
2. Add project from disk를 누릅니다.
3. `CommandPatternUnityPractice` 폴더를 선택합니다.
4. Unity Project 창에서 `Assets/Scenes/CommandPatternDemoScene`을 엽니다.
5. Play 버튼을 누릅니다.

## 조작법

- 방향키: 격자 단위로 이동
- `Z`: Undo
- `Y`: Redo
- `R`: 위치와 히스토리 초기화

## 확인할 결과

- 화면 왼쪽 위 HUD에서 현재 위치, 히스토리 개수, Undo/Redo 가능 여부가 바뀝니다.
- 이동 명령은 `MoveUnitCommand` 객체로 만들어져 `CommandHistory`에 저장됩니다.
- Undo 뒤에 새 이동을 실행하면 Redo 기록이 삭제됩니다.

## 핵심 파일

- `Assets/Scripts/MoveUnitCommand.cs`
- `Assets/Scripts/CommandHistory.cs`
- `Assets/Scripts/PlayerInputReader.cs`
- `Assets/Scripts/GridUnit.cs`
- `Assets/Scripts/GridHud.cs`

## 확장 과제

- 대각선 이동 Command 추가
- 이동 로그 저장 후 Replay 구현
- WASD 키 바인딩 추가
- 이동할 수 없는 칸을 만들고 실패한 Command는 히스토리에 넣지 않기
