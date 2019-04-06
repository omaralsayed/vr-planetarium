using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMotion : MonoBehaviour
{
    public float dist;
    public float secondsLong;
    public Transform orbitingObj;

    Vector3 oribtPos;
    float seed;

    void Start()
    {
        seed = Random.Range(0f, 6.28f);
    }

    void Update()
    {
        oribtPos.Set(Mathf.Cos(Time.time*6.28f/secondsLong)*dist+seed, 0, Mathf.Sin(Time.time*6.28f/secondsLong)*dist+seed);
        orbitingObj.position = oribtPos;
    }
}