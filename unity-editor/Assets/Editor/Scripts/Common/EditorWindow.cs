using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/*
 * Customized EditorWindow
 * 
 */


public class EditorWindow : UnityEditor.EditorWindow, IHasCustomMenu
{

    EditorPopup editorPopup = new EditorPopup();
    //string EditorWindowInformationProperty { get;  set; }



    public void AddItemsToMenu(GenericMenu menu)
    {
        menu.AddItem(new GUIContent("Editor Help"), false, OpenHelpPopup);
    }

    void OpenHelpPopup()
    {
        //editorPopup.aboutStr = EditorWindowInformationProperty;
        PopupWindow.Show(new Rect(), editorPopup);
    }

    public class EditorPopup : PopupWindowContent
    {
        public string aboutStr = "input your editor information";

        public override void OnGUI(Rect rect)
        {
            GUILayout.Label("About");
            GUILayout.Label(aboutStr);
            GUILayout.Space(10);

            GUILayout.Label("Tip");
            foreach (var content in GUILayout.contentList.Values)
            {
                UnityEngine.GUILayout.Label(content.text);
                UnityEngine.GUILayout.Label(content.tooltip);
                UnityEngine.GUILayout.Space(5);
            }
        }

        public override void OnOpen()
        {
            GUILayout.contentList.Clear();
        }

        public override void OnClose()
        {
        }
    }

}

