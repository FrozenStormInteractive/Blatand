using UnityEditor;
using UnityEngine;
using Unity.Bluetooth;

namespace Unity.Bluetooth.Editor
{
    /// <seealso cref="Uuid"/>  
    [CustomPropertyDrawer(typeof(Uuid))]
    public class UuidDrawer : PropertyDrawer 
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.PropertyField(position, property.FindPropertyRelative("m_uuid"), label);
        }
    }
}
