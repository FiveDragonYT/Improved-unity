using IUnity;
using IUnity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPhysic: MonoBehaviour
{
    [Min(0f)][SerializeField] Resource resource;
    [SerializeField] float positionSpread;
    [SerializeField] float rotationSpread;
    [SerializeField] float scaleSpread;

    float volume;
    float mass;
    Rigidbody rb;

    void Start()
    {
        Randomize();
        volume = transform.localScale.x * transform.localScale.y * transform.localScale.z;
        mass = IPhysic.GetMass(resource.density, volume);
        rb = GetComponent<Rigidbody>();
        rb.mass = mass;
    }

    void Randomize()
    {
        Vector3 position = SetRandom();
        Vector3 rotation = SetRandom();
        Vector3 scale = SetRandom();

        rotation += transform.rotation.eulerAngles;

        transform.position += position;
        transform.localScale += scale;
        transform.rotation = Quaternion.LookRotation(rotation);
    }

    Vector3 SetRandom()
    {
        Vector3 value;
        value.x = IMath.SetRandom(-positionSpread, positionSpread);
        value.y = IMath.SetRandom(-positionSpread, positionSpread);
        value.z = IMath.SetRandom(-positionSpread, positionSpread);
        return value;
    }
}