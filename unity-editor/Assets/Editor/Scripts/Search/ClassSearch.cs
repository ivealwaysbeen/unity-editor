using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;
using System.Linq;

public class ClassSearch : EditorWindow
{
    string className = "클래스 명을 입력하세요";
    bool inheritOption = false;
    public static List<Type> classList;

    [MenuItem("검색/클래스")]
    public static void Open()
    {
        ClassSearch Window = GetWindow<ClassSearch>(false,"클래스 검색");

        if(classList == null)
        {
            var results = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => type.IsClass == true);

            

            classList = new List<Type>();
            foreach(var result in results)
            {
                classList.Add(result);
            }
         
        }
    }

    void OnGUI()
    {
        if (classList == null)
            return;

        className = GUILayout.TextField(className);
        if (inheritOption = GUILayout.Toggle(inheritOption,new GUIContent("상속한 클래스","체크하면 상속하는 클래스를 찾아줍니다")))
        {
            foreach (var item in classList)
            {
                string typeStr = item.ToString();
                if (typeStr.IndexOf(className, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    GUILayout.Label(typeStr);
                    foreach (var item2 in classList)
                    {
                        if(item2.BaseType == item)
                        {
                            GUILayout.Label("   "+item2.ToString());
                        }
                    }
                }
            }
        }
        else
        {
            foreach (var item in classList)
            {
                string typeStr = item.ToString();
                if (typeStr.IndexOf(className, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    GUILayout.Label(typeStr);
                }
            }
        }
        
       


    }
}
