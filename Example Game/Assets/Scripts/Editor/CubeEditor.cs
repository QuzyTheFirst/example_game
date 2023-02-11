using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Cube))]
public class CubeEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GUILayout.Label("Generate Cube Color!", EditorStyles.boldLabel);

        Cube cube = target as Cube;

        GUILayout.BeginHorizontal();

            if (GUILayout.Button("Generate Color"))
            {
                cube.GenerateColor();
            }

            if (GUILayout.Button("Reset"))
            {
                cube.Reset();
            }

        GUILayout.EndHorizontal();
    }
}
