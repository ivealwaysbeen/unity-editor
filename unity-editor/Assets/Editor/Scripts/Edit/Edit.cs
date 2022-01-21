using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace NEdit
{
    public class Edit
    {
        [MenuItem("Edit/내부 캐시 모두 삭제",false,(int)Editor.Define.내부캐시모두삭제)]
        static void ClearAllPrefs()
        {
            PlayerPrefs.DeleteAll();
            EditorPrefs.DeleteAll();
        }
    }

}
