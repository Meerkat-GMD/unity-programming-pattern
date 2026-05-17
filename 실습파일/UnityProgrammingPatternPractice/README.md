# Unity Programming Pattern Practice

2차시 이후 실습을 하나로 모아 관리하는 통합 Unity 프로젝트입니다.

학생은 GitHub에서 이 프로젝트를 내려받은 뒤 `Assets/Scripts` 안의 `TODO`를 채워 실습을 완성합니다.

## 열기

1. Unity Hub를 엽니다.
2. Add project from disk를 누릅니다.
3. 이 폴더인 `실습파일/UnityProgrammingPatternPractice`를 선택합니다.
4. `Assets/Scenes/NN차시_PatternName` 아래에서 원하는 차시 씬을 엽니다.
5. Play 버튼을 눌러 화면에 크게 표시되는 결과를 확인합니다.
6. `Assets/Scripts/NN차시_PatternName` 안의 TODO를 채우고 다시 Play로 확인합니다.

## 폴더 구조

```text
Assets/
  Scenes/
    NN차시_PatternName/
      <LessonDemoScene>.unity
  Scripts/
    NN차시_PatternName/
      <student TODO scripts>
실습자료 정답/
  NN차시_PatternName/
    <teacher solution reference>.cs
```

## 정답 위치

교사용 정답 코드는 Unity 컴파일 대상이 아닌 프로젝트 루트의 `실습자료 정답` 폴더에 있습니다.

학생용 스크립트에는 패턴 핵심 구현부가 TODO로 남아 있으며, Unity 프로젝트는 TODO 상태에서도 열리고 실행되도록 구성되어 있습니다.

## 현재 포함 차시

- 02차시_CommandPattern: 명령 객체로 이동 입력을 캡슐화하고 Undo/Redo 흐름을 구현한다.
- 03차시_Flyweight: 지형 공유 데이터와 타일별 외부 상태를 분리해 메모리 절약 구조를 만든다.
- 04차시_Observer: 플레이어 점수가 바뀌면 HUD와 업적 시스템이 동시에 갱신되게 만든다.
- 05차시_Prototype: 몬스터 원형 데이터를 복제해 서로 다른 몬스터 인스턴스를 만든다.
- 06차시_Singleton: GameSettings 싱글턴을 만들고, 과도한 전역 접근의 문제를 로그로 확인한다.
- 07차시_State: 플레이어 상태를 Standing, Jumping, Ducking으로 분리한다.
- 08차시_DoubleBuffer: 격자의 다음 세대를 nextBuffer에 계산한 뒤 swap한다.
- 09차시_GameLoop: deltaTime을 사용해 같은 속도로 움직이는 미니 루프를 만든다.
- 10차시_UpdateMethod: 여러 Actor의 Tick을 중앙 GameTicker가 호출하게 만든다.
- 11차시_Bytecode: 간단한 Spell VM에서 PUSH, ADD, DAMAGE 명령을 실행한다.
- 12차시_SubclassSandbox: PowerUp 하위 클래스가 보호 메서드만 사용해 효과를 만든다.
- 13차시_TypeObject: Monster가 Breed 데이터를 참조해 능력치를 결정하게 만든다.
- 14차시_Component: Move, Health, RenderInfo 컴포넌트를 조합해 하나의 엔티티를 만든다.
- 15차시_EventQueue: 여러 사운드 요청을 큐에 넣고 한 프레임 끝에서 처리한다.
- 16차시_ServiceLocator: AudioService를 등록하고 플레이 요청을 로케이터로 전달한다.
- 17차시_DataLocality: Enemy 객체 리스트 대신 위치/속도 배열을 갱신한다.
- 18차시_DirtyFlag: 로컬 좌표가 바뀌면 worldPosition을 dirty로 표시하고 필요할 때 계산한다.
- 19차시_ObjectPool: ProjectilePool에서 총알을 빌리고 일정 시간 뒤 반환한다.
- 20차시_SpatialPartition: 유닛을 그리드 셀에 등록하고 주변 셀에서 가까운 유닛만 찾는다.

## 실습 규칙

- 수업 중에는 먼저 차시 PPT로 패턴의 문제 상황과 구조를 확인합니다.
- Unity에서는 해당 차시 씬을 열고 Play 버튼을 눌러 현재 TODO 상태를 확인합니다.
- 학생은 해당 차시 스크립트 폴더의 TODO만 수정합니다.
- 다른 차시 폴더의 스크립트나 씬은 섞어서 수정하지 않습니다.
- 정답 코드는 수업 후 해설 또는 교사용 확인용으로 사용합니다.
