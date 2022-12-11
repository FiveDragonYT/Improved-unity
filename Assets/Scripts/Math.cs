using System;
using UnityEngine;

public class Math
{
    #region GetMax
    public static int GetMax(params int[] args)
    {
        int result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if(result < args[i])
            {
                result = args[i];
            }
        }

        return result;
    }
    public static byte GetMax(params byte[] args)
    {
        byte result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if (result < args[i])
            {
                result = args[i];
            }
        }

        return result;
    }
    public static string GetMax(params string[] args)
    {
        string result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if (result.Length < args[i].Length)
            {
                result = args[i];
            }
        }

        return result;
    }
    #endregion
    #region GetMin
    public static int GetMin(params int[] args)
    {
        int result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if (result > args[i])
            {
                result = args[i];
            }
        }

        return result;
    }
    public static byte GetMin(params byte[] args)
    {
        byte result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if (result > args[i])
            {
                result = args[i];
            }
        }

        return result;
    }
    public static string GetMin(params string[] args)
    {
        string result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if (result.Length > args[i].Length)
            {
                result = args[i];
            }
        }

        return result;
    }
    #endregion
    #region Lerp3
    public static Vector3 Lerp3(Vector3 a, Vector3 b, Vector3 c, float t)
    {
        Vector3 result;
        if(t < 0)
        {
            result = Vector3.LerpUnclamped(a, b, t + 1f);
        }
        else
        {
            result = Vector3.LerpUnclamped(b, c, t);
        }
        return result;
    }
    public static float Lerp3(float a, float b, float c, float t)
    {
        float result;
        if (t < 0)
        {
            result = Mathf.LerpUnclamped(a, b, t + 1f);
        }
        else
        {
            result = Mathf.LerpUnclamped(b, c, t);
        }
        return result;
    }
    public static int Lerp3(int a, int b, int c, float t)
    {
        int result;
        if (t < 0)
        {
            result = (int)Mathf.LerpUnclamped(a, b, t + 1f);
        }
        else
        {
            result = (int)Mathf.LerpUnclamped(b, c, t);
        }
        return result;
    }
    #endregion
    #region ConvertToBit
    public static byte[] ConvertVector2ToBit(object obj)
    {
        Vector2 vector = (Vector2)obj;
        byte[] result = new byte[8];
        BitConverter.GetBytes(vector.x).CopyTo(result, 0);
        BitConverter.GetBytes(vector.y).CopyTo(result, 4);
        return result;
    }
    public static byte[] ConvertVector2IntToBit(object obj)
    {
        Vector2Int vector = (Vector2Int)obj;
        byte[] result = new byte[8];
        BitConverter.GetBytes(vector.x).CopyTo(result, 0);
        BitConverter.GetBytes(vector.y).CopyTo(result, 4);
        return result;
    }
    public static byte[] ConvertVector3ToBit(object obj)
    {
        Vector3 vector = (Vector3)obj;
        byte[] result = new byte[12];
        BitConverter.GetBytes(vector.x).CopyTo(result, 0);
        BitConverter.GetBytes(vector.y).CopyTo(result, 4);
        BitConverter.GetBytes(vector.y).CopyTo(result, 8);
        return result;
    }
    #endregion
    #region ConvertFromBit
    public static object ConvertByteToVector2(byte[] data)
    {
        Vector2 result = new Vector2();
        result.x = BitConverter.ToInt32(data, 0);
        result.y = BitConverter.ToInt32(data, 4);
        return result;
    }
    public static object ConvertByteToVector2Int(byte[] data)
    {
        Vector2Int result = new Vector2Int();
        result.x = BitConverter.ToInt32(data, 0);
        result.y = BitConverter.ToInt32(data, 4);
        return result;
    }
    public static object ConvertByteToVector3(byte[] data)
    {
        Vector3 result = new Vector3();
        result.x = BitConverter.ToInt32(data, 0);
        result.y = BitConverter.ToInt32(data, 4);
        result.y = BitConverter.ToInt32(data, 8);
        return result;
    }
    #endregion
}
