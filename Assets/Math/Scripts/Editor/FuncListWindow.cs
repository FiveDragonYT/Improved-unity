using UnityEngine;
using UnityEditor;

public class FuncListWindow : EditorWindow
{
    [MenuItem("Window/Math/Function list")]
    public static void ShowFuncListWindow()
    {
        GetWindow<FuncListWindow>("Functions");
    }

    private void OnGUI()
    {
        GUILayout.Label("Functions:", EditorStyles.boldLabel);
        GUILayout.Label("GetMax(int/byte/string/float/double),\nGetMin(int / byte / string / float / double),\nGetAverage(int / byte / float / double),\nGetRandom(int / byte / float / double / bool)Lerp3(int / float / Vector3 / double),\nConvertToByte(Vector2 / Vector2Int / Vector3 / Vector3Int / bool),\nConvertFromByte(Vector2 / Vector2Int / Vector3 / Vector3Int / bool).");
    }
}
