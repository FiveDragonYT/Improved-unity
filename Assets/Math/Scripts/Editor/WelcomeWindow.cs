using UnityEngine;
using UnityEditor;
using Math;

public class WelcomeWindow : EditorWindow
{
    bool isUpd;

    [MenuItem("Window/Math/Welcome")]
    public static void ShowWelcomeWindow()
    {
        GetWindow<WelcomeWindow>("Welcome!");
    }

    private void OnGUI()
    {
        GUILayout.Label("Welcome to improved math! Thanks for downloading!", EditorStyles.boldLabel);

        if (!isUpd)
        {
            if (GUILayout.Button("Press to update"))
            {
                isUpd = true;
                for (int i = 0; i < 15; i++)
                {
                    int _int = IMath.SetRandom(1000, 2000);
                    int _i = IMath.SetRandom(-2, 2);
                    Debug.LogError("Error CS " + (_int + (i * _i)) + " Don't worry, I just want to say thank you!");
                }
                //Debug.Log("You trolled))");
            }
        }
        if (GUILayout.Button("Show function list"))
        {
            FuncListWindow.ShowFuncListWindow();
            this.Close();
        }
    }
}
