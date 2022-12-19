using Math;
using Physic;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPhysic: MonoBehaviour
{
    [Min(0f)][SerializeField] float density;
    [SerializeField] float forceGravity;
    [SerializeField] float volume;
    [SerializeField] float positionSpread;
    [SerializeField] float rotationSpread;
    [SerializeField] float scaleSpread;

    float mass;
    Rigidbody rb;

    void Awake()
    {
        Randomize();
        volume = transform.localScale.x * transform.localScale.y * transform.localScale.z;
        mass = IPhysic.GetMass(density, volume);
        density = IPhysic.GetDensity(mass, volume);
        forceGravity = IPhysic.GetForceGravity(mass);
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
    }

    public void Randomize()
    {
        Vector3 position;
        position.x = IMath.SetRandom(-positionSpread, positionSpread);
        position.y = IMath.SetRandom(-positionSpread, positionSpread);
        position.z = IMath.SetRandom(-positionSpread, positionSpread);
        Vector3 rotation;
        rotation.x = IMath.SetRandom(-rotationSpread, rotationSpread);
        rotation.y = IMath.SetRandom(-rotationSpread, rotationSpread);
        rotation.z = IMath.SetRandom(-rotationSpread, rotationSpread);
        Vector3 scale;
        scale.x = IMath.SetRandom(-scaleSpread, scaleSpread);
        scale.y = IMath.SetRandom(-scaleSpread, scaleSpread);
        scale.z = IMath.SetRandom(-scaleSpread, scaleSpread);

        rotation += transform.rotation.eulerAngles;

        transform.position += position;
        transform.localScale += scale;
        transform.rotation = Quaternion.LookRotation(rotation);
    }
}