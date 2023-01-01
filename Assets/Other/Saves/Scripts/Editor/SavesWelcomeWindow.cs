using IUnity;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SavesWelcomeWindow : EditorWindow
{
    bool useEncryption;

    [MenuItem("Window/IUnity/Other/Saves/Welcome")]
    public static void ShowWelcomeWindow()
    {
        GetWindow<SavesWelcomeWindow>("Welcome!");
    }

    void OnGUI()
    {
        GUILayout.Label("Welcome to improved saves! Thanks for downloading!", EditorStyles.boldLabel);

        useEncryption = GUILayout.Toggle(useEncryption, "Use encryption?");
        SaveManager.useEncryption = useEncryption;
    }
}
