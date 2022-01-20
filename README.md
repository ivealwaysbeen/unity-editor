# unity-editor
Unity Editor Tool Project

## 개요
게임 개발에 필요한 다양한 윈도우 에디터 또는 에디터를 만들어 패키지로 제공합니다.

-------------------------

## EditorWindow
UnityEditor.EditorWindow를 상속받고, 커스터마이징할 함수들을 new keyword를 통해서 재구현합니다.

기존에 EditorWindow 객체를 생성하거나, EditorWindow 정적 메소드를 사용하는 경우를, 재구현한 EditorWindow가 대체합니다.

----------------------------------

## GUILayout
UnityWindow.GUILayout을 상속받고, 커스터마이징할 함수들을 new keyword를 통해서 재구현합니다.

---------------------------------

## 에디터 윈도우 탐색기
모든 에디터 윈도우를 검색할 수 있습니다. 


## MenuItem
UnityEditor.MenuItem을 MenuItem class를 생성하여 UnityEditor namespace를 사용하지 않을 경우 직접 만든 MenuItem class를 사용하도록 구현합니다.

주요 기능으로는 MenuItem Priority에 Enum을 사용한다거나, 생성된 MenuItem Attribute를 컨테이너에 저장합니다.(이후 확장 예정) 
