using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI logText;
    [SerializeField] private int intAmount = 10;
    private static Test _test;

    private void Start()
    {
        _test = this;
    }

    [ContextMenu("Init get min, max and average")]
    public void InitGetMinMaxAverage()
    {
        int[] _int = new int[intAmount];
        for (int i = 0; i < _int.Length; i++)
        {
            _int[i] = Math.SetRandom(0, 1000);
            Log("Int " +  (i + 1) + " seted to " + _int[i]);
        }
        int maxInt = Math.GetMax(_int);
        int minInt = Math.GetMin(_int);
        int averageInt = Math.GetAverage(_int);
        Log("Max int is " + maxInt.ToString());
        Log("Min int is " + minInt.ToString());
        Log("Average int is " + averageInt.ToString());
    }
    [ContextMenu("Init round to tenths")]
    public void InitRoundToTenths()
    {
        float[] _float = new float[intAmount];
        for (int i = 0; i < _float.Length; i++)
        {
            _float[i] = Math.SetRandom(0f, 20f);
            Log("Int " + (i + 1) + " seted to " + _float[i]);
        }
        float maxFloat = Math.GetMax(_float);
        float result = Math.RoundToTenths(maxFloat);
        Log("Max float is " + maxFloat.ToString());
        Log("Rounded float is " + result.ToString());
    }
    [ContextMenu("Init round up to hundreds")]
    public void InitRoundUpToHundreds()
    {
        int[] _int = new int[intAmount];
        for (int i = 0; i < _int.Length; i++)
        {
            _int[i] = Math.SetRandom(100, 7500);
            Log("Int " + (i + 1) + " seted to " + _int[i]);
        }
        int maxFloat = Math.GetMax(_int);
        int result = Math.RoundUpToHundreds(maxFloat);
        Log("Max int is " + maxFloat.ToString());
        Log("Rounded int is " + result.ToString());
    }

    public static void Log(string message)
    {
        Debug.Log(message);
        _test.logText.text += "\n" + message;
    }

}
