using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New resource", menuName = "Test/IPhysic/Resource")]
public class Resource : ScriptableObject
{
    [Min(0f)] public float density;
}
