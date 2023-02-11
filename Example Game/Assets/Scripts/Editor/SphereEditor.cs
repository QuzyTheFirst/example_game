using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Sphere))]
public class SphereEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Sphere sphere = target as Sphere;

        GUILayout.Label("Oscillates around a base size.", EditorStyles.boldLabel);

        sphere.baseSize = EditorGUILayout.Slider("Size", sphere.baseSize, .2f, 2f);

        sphere.transform.localScale = Vector3.one * sphere.baseSize;
    }
}
