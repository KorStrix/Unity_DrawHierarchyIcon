# Unity-Draw-Hierarchy-Icon
유니티의 하이어라키 윈도우에 게임오브젝트 옆에 아이콘을 표기합니다.

![](https://github.com/KorStrix/Unity_DrawHierarchyIcon/blob/master/Images_ForGithub/Preview.png?raw=true)

## 참고한 프로젝트
-	https://github.com/mminer/hierarchy-icons
-	https://gist.github.com/edwardrowe/acda1ee53eb037b31d54d583afc13973

## 주의사항
유니티 `2017 ~ 2018버젼까지 동작 확인`하였습니다.

```csharp
EditorApplication.hierarchyWindowItemOnGUI
```
- 상기 함수를 통해 그리기 때문에, 하이어라키 윈도우가 포커싱이 되어야 아이콘이 업데이트가 됩니다.
  - **마우스 클릭, 클릭 후 주변 이동 등의 윈도우 인풋 이벤트때**


## 기능들
1. Script에서 아이콘을 그리는 법
2. 컨피그 파일을 통하여 아이콘을 그리는 법이 있으며, 이미지와 그리기 순서를 정할 수 있습니다.

- 컨피그 파일을 통한 방법은 하단의 이미지와 같이 **Tye별로 세팅하는 법과 Tag를 이용하여 세팅하는 법이 있습니다.**
- **Odin Inspector** Asset을 활용하여 편하게 활용할 수 있으며, 없어도 사용가능합니다.


### Before Odin
<img src="https://github.com/KorStrix/Unity_DrawHierarchyIcon/blob/master/Images_ForGithub/BeforeOdin.png?raw=true" width="50%">

---
### After Odin

<img src="https://github.com/KorStrix/Unity_DrawHierarchyIcon/blob/master/Images_ForGithub/AfterOdin2.png?raw=true" width = "50%">

<img src="https://github.com/KorStrix/Unity_DrawHierarchyIcon/blob/master/Images_ForGithub///AfterOdin1.png?raw=true" width="50%">

- OdinInspector의 ValueDropDown Attribute를 활용하여 일일이 키보드 입력보다, **자동 완성을 통해 버그를 줄일 수 있습니다.**

- **Interface를 상속받아서 하이어라키 이미지 그리기를 구현** 할 수 있습니다.
![](https://github.com/KorStrix/Unity_DrawHierarchyIcon/blob/master/Images_ForGithub/Inherit.png?raw=true)
  - 그리는 이미지가 여러개일 경우 Order 순으로 Image를 출력합니다.


## 이미지
유니티 무료 에셋인 **Flat Icoon & UI - 2D Puzzle Game UI** 을 이용하였습니다.
- https://assetstore.unity.com/packages/2d/gui/icons/flat-icoon-ui-2d-puzzle-game-ui-69370

## 연락처
유니티 개발자 모임 카카오톡 & 디스코드 링크입니다.

- 카카오톡 : https://open.kakao.com/o/gOi17az
- 디스코드 : https://discord.gg/9BYFEbG
