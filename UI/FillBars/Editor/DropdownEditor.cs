using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FillBar))]
public class DropdownEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        FillBar script = (FillBar)target;

        GUIContent listLabel = new GUIContent("fillBarType");
        script.id = EditorGUILayout.Popup(listLabel, script.id, script.fillBarType.ToArray());
    }
}
