using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltCtrl : MonoBehaviour
{
    public Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        Input.gyro.enabled = true;
        movement = Vector3.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(-Input.acceleration.z/15, 0, -Input.acceleration.x/15);
    }
}
