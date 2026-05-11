# Unity Programming Pattern Practice

2차시 이후 실습을 하나로 모아 관리하는 통합 Unity 프로젝트입니다.

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
      Command Pattern 실습 코드
    03차시_Flyweight/
      Flyweight 실습 코드
```

## 2차시 Command Pattern

- 씬: `Assets/Scenes/02차시_CommandPattern/CommandPatternDemoScene`
- 조작: 방향키 이동, `Z` Undo, `Y` Redo, `R` 초기화
- 확인: 화면의 큰 HUD에서 위치, 히스토리, Undo/Redo 상태가 바뀝니다.

## 3차시 Flyweight Pattern

- 씬: `Assets/Scenes/03차시_Flyweight/FlyweightDemoScene`
- 조작: Play 버튼만 누릅니다.
- 확인: 화면에 타일맵과 공유된 `TerrainType` 참조 결과가 크게 표시됩니다.

## 새 차시 추가 규칙

- 스크립트: `Assets/Scripts/NN차시_PatternName`
- 씬: `Assets/Scenes/NN차시_PatternName`
- 기존 차시의 스크립트나 씬을 다른 차시 폴더로 섞지 않습니다.
