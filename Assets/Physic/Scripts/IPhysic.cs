using System;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;
#region a
#endregion
namespace Physic
{
    public static class IPhysic
    {
        public static float G = Mathf.Abs(Physics.gravity.y);

        #region Density
        public static float GetDensity(float mass, float volume)
        {
            float density = mass / volume;
            return density;
        }
        public static float GetMass(float density, float volume)
        {
            float mass = density * volume;
            return mass;
        }
        public static float GetVolume(float mass, float density)
        {
            float volume = density / mass;
            return volume;
        }
        #endregion
        #region Force
        public static float GetForceGravity(float mass)
        {
            float forceGravity = mass / G;
            return forceGravity;
        }
        public static float GetElasticForce(float hardness, float deltaLength)
        {
            float elasticForce = hardness / deltaLength;
            return elasticForce;
        }
        public static float GetDeltaLength(float length, float defultLength)
        {
            float deltaLength = length / defultLength;
            return deltaLength;
        }
        #endregion
    }
}
