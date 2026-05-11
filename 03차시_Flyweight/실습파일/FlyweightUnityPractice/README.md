# Flyweight Unity Practice

Game Programming Patterns의 Flyweight Pattern을 Unity/C#으로 실습하는 프로젝트입니다.

## 바로 실행하기

1. Unity Hub를 엽니다.
2. Add project from disk를 누릅니다.
3. `FlyweightUnityPractice` 폴더를 선택합니다.
4. Unity Project 창에서 `Assets/Scenes/FlyweightDemoScene`을 엽니다.
5. Play 버튼을 누릅니다.
6. Console 창에서 로그를 확인합니다.

## 확인할 결과

- 각 타일이 `Grass`, `Hill`, `River` 중 하나의 지형 타입을 가집니다.
- 같은 지형의 여러 타일은 새 지형 객체를 계속 만들지 않고 같은 `TerrainType` 인스턴스를 공유합니다.
- Console에 타일 정보와 `Same TerrainType reference?` 결과가 출력됩니다.

## 핵심 파일

- `Assets/Scripts/TerrainType.cs`
- `Assets/Scripts/TileInstance.cs`
- `Assets/Scripts/WorldGrid.cs`
- `Assets/Scripts/FlyweightDemo.cs`

## 확장 과제

- `TerrainType`을 ScriptableObject 기반 `TerrainTypeAsset`으로 바꾸기
- 클릭한 타일의 이동 비용과 물 여부를 HUD에 표시하기
- 타일을 실제 Sprite나 Tilemap으로 시각화하기
