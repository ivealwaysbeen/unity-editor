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
    /// <summary>
    /// Application.isPlaying을 반환하고,
    /// 시작 중에만 사용할 수 있음을 알리는 라벨을 생성해준다
    /// </summary>
    public static bool ValidateApplicationIsPlaying()
    {
        bool isPlaying = Application.isPlaying;
        if (isPlaying == false)
        {
            Label(new GUIContent("게임 시작 중에 사용하실 수 있습니다.", "게임이 시작된 상태에서만 작동하는 툴입니다."));
        }

        return isPlaying;
    }

    static GUIStyle warningStyle;
    public static GUIStyle WarningStyle
    {
        get
        {
            if (warningStyle == null)
            {
                warningStyle = new GUIStyle();
                warningStyle.normal.textColor = Color.yellow;
            }

            return warningStyle;
        }
    }
    static GUIStyle activateStyle;
    public static GUIStyle ActivateStyle
    {
        get
        {
            if (activateStyle == null)
            {
                activateStyle = new GUIStyle();
                activateStyle.normal.textColor = Color.green;
            }

            return activateStyle;
        }
    }

    public delegate void ButtonClickDelegate();
    /// <summary>
    /// OnGUI에서만 불리는 함수
    /// 버튼이 눌렸을 때 어떤 행동을 하는 것을 메서드로 구현
    /// </summary>
    /// <param name="text">버튼의 제목</param>
    /// <param name="tooltip">버튼의 툴탑</param>
    /// <param name="buttonClickDelegate">버튼을 눌렸을 때 실행할 함수(파라미터 없음)</param>
    public static void ButtonClicker(string text, string tooltip, ButtonClickDelegate buttonClickDelegate)
    {
        if (Button(new GUIContent(text, tooltip)) == true)
        {
            buttonClickDelegate.Invoke();
        }
    }

    public static void BeginHorizontalFlexible()
    {
        UnityEngine.GUILayout.BeginHorizontal();
        GUILayout.FlexibleSpace();
    }

    public static void EndHorizontalFlexible()
    {
        GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
    }

    public static Dictionary<string, GUIContent> contentList = new Dictionary<string, GUIContent>();

    static void AddContentList(GUIContent content)
    {
        if(contentList.ContainsKey(content.text) == false)
        {
            contentList.Add(content.text, content);
        }
    }

    public static new bool Button(GUIContent content, params GUILayoutOption[] options)
    {
        AddContentList(content);
        return UnityEngine.GUILayout.Button(content, options);
    }
    public static new bool Button(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        AddContentList(content);
        return UnityEngine.GUILayout.Button(content, style, options);
    }

    public static new void Label(GUIContent content, params GUILayoutOption[] options)
    {
        AddContentList(content);
        UnityEngine.GUILayout.Label(content, options);
    }
    public static new void Label(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        AddContentList(content);
        UnityEngine.GUILayout.Label(content, style, options);
    }
    public static new void Box(GUIContent content, params GUILayoutOption[] options)
    {
        AddContentList(content);
        UnityEngine.GUILayout.Box(content, options);
    }
    public static new void Box(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        AddContentList(content);
        UnityEngine.GUILayout.Box(content, style, options);
    }
    public static new bool RepeatButton(GUIContent content, params GUILayoutOption[] options)
    {
        AddContentList(content);
        return UnityEngine.GUILayout.RepeatButton(content, options);
    }
    public static new bool RepeatButton(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        AddContentList(content);
        return UnityEngine.GUILayout.RepeatButton(content, style, options);
    }
    public static new bool Toggle(bool value, GUIContent content, params GUILayoutOption[] options)
    {
        AddContentList(content);
        return UnityEngine.GUILayout.Toggle(value, content, options);
    }
    public static new bool Toggle(bool value, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        AddContentList(content);
        return UnityEngine.GUILayout.Toggle(value, content, style, options);
    }
    public static new int Toolbar(int selected, GUIContent[] contents, params GUILayoutOption[] options)
    {
        foreach(var content in contents)
        {
            AddContentList(content);
        }
        return UnityEngine.GUILayout.Toolbar(selected, contents, options);
    }
    public static new int Toolbar(int selected, GUIContent[] contents, GUIStyle style, params GUILayoutOption[] options)
    {
        foreach (var content in contents)
        {
            AddContentList(content);
        }
        return UnityEngine.GUILayout.Toolbar(selected, contents, style, options);
    }

    public static new int Toolbar(int selected, GUIContent[] contents, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
    {
        foreach (var content in contents)
        {
            AddContentList(content);
        }
        return UnityEngine.GUILayout.Toolbar(selected, contents, style, buttonSize, options);
    }

    public static new int Toolbar(int selected, GUIContent[] contents, bool[] enabled, GUIStyle style, params GUILayoutOption[] options)
    {
        foreach (var content in contents)
        {
            AddContentList(content);
        }
        return UnityEngine.GUILayout.Toolbar(selected, contents, enabled, style, options);
    }

    public static new int Toolbar(int selected, GUIContent[] contents, bool[] enabled, GUIStyle style, GUI.ToolbarButtonSize buttonSize, params GUILayoutOption[] options)
    {
        foreach (var content in contents)
        {
            AddContentList(content);
        }
        return UnityEngine.GUILayout.Toolbar(selected, contents, enabled, style, buttonSize, options);
    }

    public static new int SelectionGrid(int selected, GUIContent[] content, int xCount, params GUILayoutOption[] options)
    {
        foreach (var c in content)
        {
            AddContentList(c);
        }
        return UnityEngine.GUILayout.SelectionGrid(selected, content, xCount, options);
    }
    public static new int SelectionGrid(int selected, GUIContent[] contents, int xCount, GUIStyle style, params GUILayoutOption[] options)
    {
        foreach (var content in contents)
        {
            AddContentList(content);
        }
        return UnityEngine.GUILayout.SelectionGrid(selected, contents, xCount,style, options);
    }

    public static new void BeginHorizontal(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        AddContentList(content);
        UnityEngine.GUILayout.BeginHorizontal(content, style, options);
    }
    public static new void BeginVertical(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        AddContentList(content);
        UnityEngine.GUILayout.BeginVertical(content, style, options);
    }

    public static new void BeginArea(Rect screenRect, GUIContent content)
    {
        AddContentList(content);
        UnityEngine.GUILayout.BeginArea(screenRect,content);
    }
    public static new void BeginArea(Rect screenRect, GUIContent content, GUIStyle style)
    {
        AddContentList(content);
        UnityEngine.GUILayout.BeginArea(screenRect, content,style);
    }

    public static new Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, params GUILayoutOption[] options)
    {
        AddContentList(content);
        return UnityEngine.GUILayout.Window(id,screenRect,func,content,options);
    }
    public static new Rect Window(int id, Rect screenRect, GUI.WindowFunction func, GUIContent content, GUIStyle style, params GUILayoutOption[] options)
    {
        AddContentList(content);
        return UnityEngine.GUILayout.Window(id, screenRect, func, content, style, options);
    }


}
