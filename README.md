# Unity Programming Pattern

경기게임마이스터고 방과후학교 Unity 프로그래밍 패턴 수업 자료 저장소입니다.

강의 자료는 차시별 폴더에 두고, Unity 실습은 하나의 통합 프로젝트에서 관리합니다.

```text
02차시_CommandPattern/
  강의자료/
    유니티 프로그래밍 패턴 2차시 - Command Pattern.pptx
  미리보기/
    PPT 렌더링 검수 이미지

03차시_Flyweight/
  강의자료/
    유니티 프로그래밍 패턴 3차시 - Flyweight.pptx
  미리보기/
    PPT 렌더링 검수 이미지

실습파일/
  UnityProgrammingPatternPractice/
    Assets/
      Scenes/
        02차시_CommandPattern/
        03차시_Flyweight/
      Scripts/
        02차시_CommandPattern/
        03차시_Flyweight/
```

## 실습 실행 방법

1. Unity Hub를 엽니다.
2. Add project from disk를 누릅니다.
3. `실습파일/UnityProgrammingPatternPractice` 폴더를 선택합니다.
4. Unity Project 창에서 원하는 차시의 `Assets/Scenes/...` 씬을 엽니다.
5. Play 버튼을 눌러 결과를 확인합니다.

## 현재 차시

- `02차시_CommandPattern`: Command Pattern 강의 PPT, `CommandPatternDemoScene`
- `03차시_Flyweight`: Flyweight Pattern 강의 PPT, `FlyweightDemoScene`

## 관리 규칙

- 새 차시는 `NN차시_PatternName` 형식의 폴더로 추가합니다.
- PPT는 각 차시의 `강의자료` 폴더에 둡니다.
- 실습 스크립트는 통합 Unity 프로젝트의 `Assets/Scripts/NN차시_PatternName`에 둡니다.
- 실습 씬은 통합 Unity 프로젝트의 `Assets/Scenes/NN차시_PatternName`에 둡니다.
- Unity의 `Library`, `Temp`, `Obj`, `Build`, `Logs`, `UserSettings` 폴더는 Git에 올리지 않습니다.
