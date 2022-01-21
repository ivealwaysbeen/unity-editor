using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class InActiveCollector : EditorWindow
{
    [MenuItem("기능/비활성화 오브젝트 콜렉터",false,(int)Editor.Define.비활성화_오브젝트_모으기)]
    static void OpenWindow()
    {
        InActiveCollector Window = GetWindow<InActiveCollector>(false, "InActive Collector");
    }
    private void OnGUI()
    {
        if (GUILayout.ValidateApplicationIsPlaying() == false)
            return;


        GUILayout.ButtonClicker("가져오기", "비활성화 상태인 게임 오브젝트를 가져옵니다", GetInActiveGameObject);

    }

    void GetInActiveGameObject()
    {
        Debug.Log("비활성화 오브젝트 가져옴.");
    }
}
