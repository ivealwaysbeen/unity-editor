using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Editor.GameObject
{
    public class Shortcut : EditorWindow
    {

        //선택한 오브젝트들의 최상단 오브젝트의 
        [MenuItem("GameObject/SetParent %g")]
        static void SetParent()
        {
            var selectionTransform = Selection.transforms;
            foreach(var selection in selectionTransform)
            {
                Debug.Log(selection);
            }
        }

        [MenuItem("GameObject/SetParent %g",true)]
        static bool ValidateSetParent()
        {
            if (Selection.transforms.Length == 0) return false;
            else return true;
        }


    }

}
