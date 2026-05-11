# Unity Programming Pattern Practice

2차시 이후 실습을 하나로 모아 관리하는 통합 Unity 프로젝트입니다.

학생은 GitHub에서 이 프로젝트를 내려받은 뒤 `Assets/Scripts` 안의 `TODO`를 채워 실습을 완성합니다.

## 열기

1. Unity Hub를 엽니다.
2. Add project from disk를 누릅니다.
3. 이 폴더인 `UnityProgrammingPatternPractice`를 선택합니다.
4. `Assets/Scenes` 아래에서 원하는 차시 폴더의 씬을 엽니다.
5. Play 버튼을 누릅니다.

## 차시별 위치

```text
Assets/
  Scenes/
    02차시_CommandPattern/
      CommandPatternDemoScene.unity
    03차시_Flyweight/
      FlyweightDemoScene.unity
  Scripts/
    02차시_CommandPattern/
      Command Pattern TODO 코드
    03차시_Flyweight/
      Flyweight TODO 코드
```

## 2차시 Command Pattern

씬: `Assets/Scenes/02차시_CommandPattern/CommandPatternDemoScene`

수정할 파일:

- `Assets/Scripts/02차시_CommandPattern/MoveUnitCommand.cs`
- `Assets/Scripts/02차시_CommandPattern/CommandHistory.cs`
- `Assets/Scripts/02차시_CommandPattern/PlayerInputReader.cs`

TODO 목표:

- 이동 전 위치를 저장한다.
- 이동 요청을 `MoveUnitCommand` 객체로 만든다.
- `CommandHistory`가 Execute, Undo, Redo 흐름을 관리한다.
- Undo 뒤 새 명령을 실행하면 Redo 기록을 삭제한다.

통과 기준:

- 방향키를 누르면 유닛이 이동한다.
- `Z`를 누르면 이전 위치로 돌아간다.
- `Y`를 누르면 되돌린 명령을 다시 실행한다.
- 화면 HUD의 위치, 히스토리 개수, Undo/Redo 상태가 바뀐다.

## 3차시 Flyweight Pattern

씬: `Assets/Scenes/03차시_Flyweight/FlyweightDemoScene`

수정할 파일:

- `Assets/Scripts/03차시_Flyweight/TerrainType.cs`
- `Assets/Scripts/03차시_Flyweight/TileInstance.cs`
- `Assets/Scripts/03차시_Flyweight/WorldGrid.cs`

TODO 목표:

- `TerrainType`에 지형 이름, 이동 비용, 물 여부, 색상 정보를 저장한다.
- `TileInstance`는 좌표와 공유 `TerrainType` 참조만 가진다.
- `WorldGrid`는 Grass, Hill, River를 한 번만 만들고 여러 타일이 공유하게 한다.
- 타일을 만들 때 루프 안에서 `new TerrainType(...)`을 반복 호출하지 않는다.

통과 기준:

- Play를 누르면 화면에 여러 색상의 타일맵이 보인다.
- 오른쪽 패널에 선택된 두 타일의 지형 정보가 표시된다.
- 같은 지형 타일들이 같은 `TerrainType` 인스턴스를 공유한다.

## 새 차시 추가 규칙

- 스크립트: `Assets/Scripts/NN차시_PatternName`
- 씬: `Assets/Scenes/NN차시_PatternName`
- 기존 차시의 스크립트나 씬을 다른 차시 폴더로 섞지 않습니다.
