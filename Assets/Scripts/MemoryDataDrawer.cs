using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(MemoryData))]
public class MemoryDataDrawer : PropertyDrawer
{
    
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
        // The 6 comes from extra spacing between the fields (2px each)
        return EditorGUIUtility.singleLineHeight * 4 + 50;
    }
    

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
        EditorGUI.BeginProperty(position, label, property);

        EditorGUI.LabelField(new Rect(position.x, position.y, position.width, 16), label);

        var nameRect = new Rect(position.x, position.y + 18, position.width, 16);
        var descriptionRect = new Rect(position.x, position.y + 36, position.width, 64);
        var spriteRect = new Rect(position.x, position.y + 100, position.width, 16);

        EditorGUI.indentLevel++;

        EditorGUI.PropertyField(nameRect, property.FindPropertyRelative("name"));
        EditorGUI.PropertyField(descriptionRect, property.FindPropertyRelative("description"));
        EditorGUI.PropertyField(spriteRect, property.FindPropertyRelative("sprite"));

        EditorGUI.indentLevel--;

        EditorGUI.EndProperty();
    }
}
