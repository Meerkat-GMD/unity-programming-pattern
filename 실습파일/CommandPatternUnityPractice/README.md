# Command Pattern Unity Practice

Game Programming Patterns의 Command Pattern을 Unity/C#으로 실습하는 스타터 프로젝트입니다.

## 수업 목표

- 입력 코드가 게임 상태를 직접 바꾸지 않게 만들기
- `MoveUnitCommand`로 이동 요청을 객체화하기
- `CommandHistory`로 Execute, Undo, Redo 흐름 구현하기
- Undo 후 새 명령을 실행하면 Redo 후보가 사라지는 규칙 확인하기

## Git으로 받기

교사가 GitHub에 업로드한 뒤 학생은 아래처럼 받습니다.

```bash
git clone <GitHub 저장소 URL>
```

로컬 폴더만 공유받은 경우에도 이 폴더 안에서 아래 명령으로 저장소 상태를 확인할 수 있습니다.

```bash
git status
```

## Unity에서 열기

1. Unity Hub를 연다.
2. Add project from disk를 누른다.
3. `CommandPatternUnityPractice` 폴더를 선택한다.
4. 빈 2D Scene을 만든다.
5. 빈 GameObject를 만들고 `PlayerInputReader`, `CommandHistory`, `GridUnit`, `GridHud`를 붙인다.
6. Inspector에서 `PlayerInputReader`의 `Unit`, `History` 참조를 연결한다.
7. `GridHud`의 `Unit`, `History` 참조도 연결한다.

## 학생 TODO

`Assets/Scripts`의 TODO를 완성하세요.

1. `MoveUnitCommand.Execute()`에서 이동 전 위치를 저장한다.
2. `MoveUnitCommand.Undo()`에서 이전 위치로 되돌린다.
3. `CommandHistory.Execute()`에서 Redo 후보를 삭제하고 새 명령을 저장한다.
4. `CommandHistory.Undo()`와 `Redo()`의 범위 체크를 완성한다.
5. `PlayerInputReader`에서 방향키 입력이 `MoveUnitCommand`를 만들게 한다.

## 조작법

- 방향키: 유닛을 격자 단위로 이동
- `Z`: Undo
- `Y`: Redo
- `R`: 위치와 히스토리 초기화

## 통과 기준

- 방향키 이동이 된다.
- 입력 코드에서 `unit.MoveTo(...)`를 직접 호출하지 않는다.
- Undo 후 새 이동을 하면 Redo가 사라진다.
- `CommandHistory.Count`, `CurrentIndex`가 화면에 표시된다.

## 확장 과제

- 대각선 이동 Command 추가
- 이동 로그를 저장하고 Replay 구현
- WASD 키 바인딩 추가
- AI가 랜덤 Command를 생성하게 만들기
- 이동 불가능한 칸을 만들고 실패한 Command는 히스토리에 넣지 않기
