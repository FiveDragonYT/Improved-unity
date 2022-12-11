using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Awake()
    {
        int[] max = new int[16];
        for (int i = 0; i < max.Length; i++)
        {
            max[i] = Random.Range(-100, 100);
            Debug.Log("Int " +  i + " seted to " + max[i]);
        }
        int maxInt = Math.GetMax(max);
        Debug.Log("Max int is " + maxInt.ToString());
    }
}
