using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using IUnity;

public class TestMath : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI logText;
    [SerializeField] private int intAmount = 10;

    [ContextMenu("Init get min, max and average")]
    public void InitGetMinMaxAverage()
    {
        int[] _int = new int[intAmount];
        for (int i = 0; i < _int.Length; i++)
        {
            _int[i] = IMath.SetRandom(0, 1000);
            Log("Int " +  (i + 1) + " seted to " + _int[i]);
        }
        int maxInt = IMath.GetMax(_int);
        int minInt = IMath.GetMin(_int);
        int averageInt = IMath.GetAverage(_int);
        Log("Max int is " + maxInt.ToString());
        Log("Min int is " + minInt.ToString());
        Log("Average int is " + averageInt.ToString());
        Log("");
    }
    [ContextMenu("Init round to tenths")]
    public void InitRoundToTenths()
    {
        float[] _float = new float[intAmount];
        for (int i = 0; i < _float.Length; i++)
        {
            _float[i] = IMath.SetRandom(0f, 20f);
            Log("Int " + (i + 1) + " seted to " + _float[i]);
        }
        float maxFloat = IMath.GetMax(_float);
        float result = IMath.RoundToTenths(maxFloat);
        Log("Max float is " + maxFloat.ToString());
        Log("Rounded float is " + result.ToString());
        Log("");
    }
    [ContextMenu("Init round up to hundreds")]
    public void InitRoundUpToHundreds()
    {
        int[] _int = new int[intAmount];
        for (int i = 0; i < _int.Length; i++)
        {
            _int[i] = IMath.SetRandom(100, 7500);
            Log("Int " + (i + 1) + " seted to " + _int[i]);
        }
        int maxFloat = IMath.GetMax(_int);
        int result = IMath.RoundUpToHundreds(maxFloat);
        Log("Max int is " + maxFloat.ToString());
        Log("Rounded int is " + result.ToString());
        Log("");
    }
    public void Log(string message)
    {
        Debug.Log(message);
        logText.text += "\n" + message;
    }
    public void ClearLog()
    {
        logText.text = "Log:";
    }

}
