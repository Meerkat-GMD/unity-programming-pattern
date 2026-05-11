# Flyweight Unity Practice

Flyweight 패턴을 타일 지형 데이터 공유로 실습하는 Unity 스타터 프로젝트입니다.

## 목표

- `TerrainType`은 지형의 공통 데이터만 가진다.
- `TileInstance`는 좌표와 `TerrainType` 참조만 가진다.
- 같은 지형 타입의 타일은 같은 `TerrainType` 인스턴스를 공유한다.
- 타일 정보는 `switch`가 아니라 `TerrainType` 객체에서 읽는다.

## Unity에서 열기

1. Unity Hub를 연다.
2. Add project from disk를 누른다.
3. `FlyweightUnityPractice` 폴더를 선택한다.
4. 빈 2D Scene을 만든다.
5. 빈 GameObject에 `FlyweightDemo`를 붙인다.
6. Play 후 콘솔 로그를 확인한다.

## 학생 TODO

1. `TerrainType`을 읽기 전용 데이터 객체로 완성한다.
2. `WorldGrid.CreateTerrainTypes()`에서 Grass, Hill, River 공유 인스턴스를 만든다.
3. `WorldGrid.Generate()`에서 타일마다 새 `TerrainType`을 만들지 않는다.
4. 같은 Grass 타일들이 같은 참조를 공유하는지 로그로 확인한다.

## 조작/확장

- 기본 실습은 콘솔 로그로 검증한다.
- 확장 과제: ScriptableObject 기반 TerrainTypeAsset으로 바꾸기
- 확장 과제: 타일 클릭 시 HUD에 이동 비용과 물 여부 표시하기
