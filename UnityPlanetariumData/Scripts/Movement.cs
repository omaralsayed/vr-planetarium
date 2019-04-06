using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Movement : MonoBehaviour
{
    public float speed = 20f;
    public float friction_multiplier = 0.99f;
    double x_i = 0;
    double y_i = 0;
    double z_i = 0;
    // Update is called once per frame
    void Update()
    {

        // Store the input axes.
        x_i += Input.GetAxisRaw("Horizontal") / 200;
        x_i *= friction_multiplier * (1f / Math.Pow(2.717, Time.deltaTime));
        y_i += Input.GetAxisRaw("Vertical") / 200;
        y_i *= friction_multiplier * (1f / Math.Pow(2.717, Time.deltaTime));
        if (Input.GetButton("Fire1"))
        {
            z_i += 1f / 200f;
        }
        if (Input.GetButton("Fire2"))
        {
            z_i -= 1f / 200f;
        }
        z_i *= friction_multiplier * (1f / Math.Pow(2.717, Time.deltaTime));

        transform.Translate(new Vector3((float)x_i, (float)y_i, (float)z_i));

    }


}
