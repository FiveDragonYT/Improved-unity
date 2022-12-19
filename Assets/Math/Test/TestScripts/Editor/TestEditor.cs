using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TestMath))]
public class TestEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        TestMath _test = (TestMath)target;

        if (!Application.isPlaying)
        {
            GUILayout.Label("Use in play mode", EditorStyles.boldLabel);
            return;
        }

        if (GUILayout.Button("Init get min, max and average"))
        {
            _test.InitGetMinMaxAverage();
        }
        if (GUILayout.Button("Init round to tenths"))
        {
            _test.InitRoundToTenths();
        }
        if (GUILayout.Button("Init round up to hundreds"))
        {
            _test.InitRoundUpToHundreds();
        }

        if (GUILayout.Button("Clear log"))
        {
            _test.ClearLog();
        }
    }
}
