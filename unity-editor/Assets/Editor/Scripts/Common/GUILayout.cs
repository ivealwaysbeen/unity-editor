using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/// <summary>
///   <para>GUILayout을 커스터마이징합니다</para>
/// </summary>
/// 기존의 UnityEngine.GUILayout을 호출하기 전에 다른 기능을 수행할 수 있습니다.
/// 
public class GUILayout : UnityEngine.GUILayout
{
    

    public static new bool Button(GUIContent content, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.Button(content, options);
    }
    public static new bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.Button(content, style, options);
    }

    public static new void Label(GUIContent content, params GUILayoutOption[] options)
    {
        UnityEngine.GUILayout.Label(content, options);
    }
    public static new void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        UnityEngine.GUILayout.Label(content, style, options);
    }
    public static new void Box(GUIContent content, params GUILayoutOption[] options)
    {
        UnityEngine.GUILayout.Box(content, options);
    }
    public static new void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        UnityEngine.GUILayout.Box(content, style, options);
    }
    public static new bool RepeatButton(GUIContent content, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.RepeatButton(content, options);
    }
    public static new bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.RepeatButton(content, style, options);
    }
    public static new bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.Toggle(value, content, options);
    }
    public static new bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.Toggle(value, content, style, options);
    }
    public static new int Toolbar(int selected, GUIContent[] contents, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.Toolbar(selected, contents, options);
    }
    public static new int Toolbar(int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.Toolbar(selected, contents, style, options);
    }

    public static new int Toolbar(int selected, GUIContent[] contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.Toolbar(selected, contents, style, buttonSize, options);
    }

    public static new int Toolbar(int selected, GUIContent[] contents, bool[] enabled, GUIStyle style, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.Toolbar(selected, contents, enabled, style, options);
    }

    public static new int Toolbar(int selected, GUIContent[] contents, bool[] enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.Toolbar(selected, contents, enabled, style, buttonSize, options);
    }

    public static new int SelectionGrid(int selected, GUIContent[] content, int xCount, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.SelectionGrid(selected, content, xCount, options);
    }
    public static new int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.SelectionGrid(selected, contents, xCount,style, options);
    }

    public static new void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        UnityEngine.GUILayout.BeginHorizontal(content, style, options);
    }
    public static new void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        UnityEngine.GUILayout.BeginVertical(content, style, options);
    }

    public static new void BeginArea(Rect screenRect, GUIContent content)
    {
        UnityEngine.GUILayout.BeginArea(screenRect,content);
    }
    public static new void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
    {
        UnityEngine.GUILayout.BeginArea(screenRect, content,style);
    }

    public static new Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.Window(id,screenRect,func,content,options);
    }
    public static new Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        return UnityEngine.GUILayout.Window(id, screenRect, func, content, style, options);
    }


}
