using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/*
 * Customized EditorWindow
 * 
 */

public abstract class AEditorWindow : UnityEditor.EditorWindow
{
    protected abstract void OnGUI();
}
public class EditorWindow : AEditorWindow
{

    protected override sealed void OnGUI()
    {
        BaseOnGUI();
        NextOnGUI();
    }

    //called in the OnGUI function of all classes that inherit EditorWindow
    void BaseOnGUI()
    {
        
    }
    
    //class that inherit EditorWindow use this method instead of OnGUI()
    //if you want to make EditorWindow to abstract class, change this method to abstract...
    protected virtual void NextOnGUI(){}


}
