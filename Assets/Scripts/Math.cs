using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Math
{
    #region GetMax
    public static int GetMax(params int[] args)
    {
        int result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if (result < args[i])
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
    public static float GetMax(params float[] args)
    {
        float result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if (result < args[i])
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
    public static float GetMin(params float[] args)
    {
        float result = args[0];

        for (int i = 0; i < args.Length; i++)
        {
            if (result > args[i])
            {
                result = args[i];
            }
        }

        return result;
    }
    #endregion
    #region GetAverage
    public static int GetAverage(params int[] args)
    {
        int result = 0;

        for (int i = 0; i < args.Length; i++)
        {
            result += args[i];

        }
        result = result / args.Length;
        result = Mathf.RoundToInt(result);
        return result;
    }
    public static float GetAverage(params float[] args)
    {
        float result = 0;

        for (int i = 0; i < args.Length; i++)
        {
            result += args[i];

        }
        result = result / args.Length;
        return result;
    }
    public static byte GetAverage(params byte[] args)
    {
        byte result = 0;

        for (int i = 0; i < args.Length; i++)
        {
            result += args[i];

        }
        result = (byte)(result / args.Length);
        result = (byte)(Mathf.RoundToInt(result));
        return result;
    }
    #endregion
    #region Lerp3
    public static Vector3 Lerp3(Vector3 a, Vector3 b, Vector3 c, float t)
    {
        Vector3 result;
        if (t < 0)
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
    public static Vector2 Lerp3(Vector2 a, Vector2 b, Vector2 c, float t)
    {
        Vector2 result;
        if (t < 0)
        {
            result = Vector2.LerpUnclamped(a, b, t + 1f);
        }
        else
        {
            result = Vector2.LerpUnclamped(b, c, t);
        }
        return result;
    }
    public static Vector2Int Lerp3(Vector2Int a, Vector2Int b, Vector2Int c, float t)
    {
        Vector2Int result = new Vector2Int();
        if (t < 0)
        {
            result.x = Mathf.RoundToInt(Mathf.LerpUnclamped(a.x, b.x, t + 1f));
            result.y = Mathf.RoundToInt(Mathf.LerpUnclamped(a.y, b.y, t + 1f));
        }
        else
        {
            result.x = Mathf.RoundToInt(Mathf.LerpUnclamped(b.x, c.x, t));
            result.y = Mathf.RoundToInt(Mathf.LerpUnclamped(b.y, c.y, t));
        }
        return result;
    }
    public static Vector3Int Lerp3(Vector3Int a, Vector3Int b, Vector3Int c, float t)
    {
        Vector3Int result = new Vector3Int();
        if (t < 0)
        {
            result.x = Mathf.RoundToInt(Mathf.LerpUnclamped(a.x, b.x, t + 1f));
            result.y = Mathf.RoundToInt(Mathf.LerpUnclamped(a.y, b.y, t + 1f));
            result.z = Mathf.RoundToInt(Mathf.LerpUnclamped(a.z, b.z, t + 1f));
        }
        else
        {
            result.x = Mathf.RoundToInt(Mathf.LerpUnclamped(b.x, c.x, t));
            result.y = Mathf.RoundToInt(Mathf.LerpUnclamped(b.y, c.y, t));
            result.z = Mathf.RoundToInt(Mathf.LerpUnclamped(b.z, c.z, t));
        }
        return result;
    }
    #endregion
    #region ConvertToByte
    public static byte[] ConvertVector2ToByte(object obj)
    {
        Vector2 vector = (Vector2)obj;
        byte[] result = new byte[8];
        BitConverter.GetBytes(vector.x).CopyTo(result, 0);
        BitConverter.GetBytes(vector.y).CopyTo(result, 4);
        return result;
    }
    public static byte[] ConvertVector2IntToByte(object obj)
    {
        Vector2Int vector = (Vector2Int)obj;
        byte[] result = new byte[8];
        BitConverter.GetBytes(vector.x).CopyTo(result, 0);
        BitConverter.GetBytes(vector.y).CopyTo(result, 4);
        return result;
    }
    public static byte[] ConvertVector3ToByte(object obj)
    {
        Vector3 vector = (Vector3)obj;
        byte[] result = new byte[12];
        BitConverter.GetBytes(vector.x).CopyTo(result, 0);
        BitConverter.GetBytes(vector.y).CopyTo(result, 4);
        BitConverter.GetBytes(vector.z).CopyTo(result, 8);
        return result;
    }
    public static byte[] ConvertVector3IntToByte(object obj)
    {
        Vector3Int vector = (Vector3Int)obj;
        byte[] result = new byte[12];
        BitConverter.GetBytes(vector.x).CopyTo(result, 0);
        BitConverter.GetBytes(vector.y).CopyTo(result, 4);
        BitConverter.GetBytes(vector.z).CopyTo(result, 8);
        return result;
    }
    public static byte[] ConvertBoolToByte(object obj)
    {
        bool _bool = (bool)obj;
        byte[] result = new byte[8];
        BitConverter.GetBytes(_bool).CopyTo(result, 0);
        return result;
    }
    #endregion
    #region ConvertFromByte
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
        result.z = BitConverter.ToInt32(data, 8);
        return result;
    }
    public static object ConvertByteToVector3Int(byte[] data)
    {
        Vector3Int result = new Vector3Int();
        result.x = BitConverter.ToInt32(data, 0);
        result.y = BitConverter.ToInt32(data, 4);
        result.z = BitConverter.ToInt32(data, 8);
        return result;
    }
    public static object ConvertByteToBool(byte[] data)
    {
        bool result = new bool();
        result = BitConverter.ToBoolean(data, 0);
        return result;
    }
    #endregion
    #region SetRandom
    public static int SetRandom(int min, int max)
    {
        int result = Random.Range(min, max + 1);
        return result;
    }
    public static float SetRandom(float min, float max)
    {
        float result = Random.Range(min * 10000, max * 10000 + 1) / 10000;
        return result;
    }
    #endregion
    #region Round
    public static float RoundToTenths(float a)
    {
        float result;
        result = Mathf.Round(a * 10) / 10;
        return result;
    }
    public static float RoundToHundredths(float a)
    {
        float result;
        result = Mathf.Round(a * 100) / 100;
        return result;
    }
    public static float RoundToThousandths(float a)
    {
        float result;
        result = Mathf.Round(a * 1000) / 1000;
        return result;
    }
    public static int RoundUpToTens(int a)
    {
        int result;
        result = Mathf.RoundToInt(a / 10) * 10;
        return result;
    }
    public static int RoundUpToHundreds(int a)
    {
        int result;
        result = Mathf.RoundToInt(a / 100) * 100;
        return result;
    }
    public static int RoundUpToThousands(int a)
    {
        int result;
        result = Mathf.RoundToInt(a / 1000) * 1000;
        return result;
    }
    #endregion
}
