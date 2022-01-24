using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class InActiveCollector : EditorWindow
{
    public class InActiveGameObject
    {
        public Transform parent;
        public GameObject gameObject;
        public Transform transform;

        public InActiveGameObject(Transform parent, GameObject go, Transform t)
        {
            this.parent = parent;
            this.gameObject = go;
            this.transform = t;
        }
    }
    GameObject objectPool;
    bool onlyRootObject = true;

    [MenuItem("기능/비활성화 오브젝트 콜렉터",false,(int)Editor.Define.비활성화_오브젝트_모으기)]
    static void OpenWindow()
    {
        InActiveCollector Window = GetWindow<InActiveCollector>(false, "InActive Collector");
    }
    private void OnGUI()
    {
        if (GUILayout.ValidateApplicationIsPlaying() == false)
            return;

        onlyRootObject = GUILayout.Toggle(onlyRootObject, new GUIContent("루트 오브젝트만", "토글이 체크되어 있을 경우, 하이라키에 존재하는 루트 오브젝트만 수집합니다."));

        GUILayout.ButtonClicker("가져오기", "비활성화 상태인 게임 오브젝트를 가져옵니다", GetInActiveGameObject);

    }

    void GetInActiveGameObject()
    {
        if(objectPool == null)
        {
            objectPool = new GameObject("ObjectPool");
        }

        var gameObjects = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();

        if(onlyRootObject == false)
        {
            foreach(var go in gameObjects)
            {
                for(int i = 0; i < go.transform.childCount; i++)
                {
                    var childGo = go.transform.GetChild(i).gameObject;
                    if (childGo.activeSelf == false)
                    {
                        childGo.transform.SetParent(objectPool.transform);
                    }
                }
            }
        }

        if (gameObjects == null)
            return;

        foreach (var go in gameObjects)
        {
            if (go.activeSelf == false)
            {
                go.transform.SetParent(objectPool.transform);
            }
        }
    }

    
}
