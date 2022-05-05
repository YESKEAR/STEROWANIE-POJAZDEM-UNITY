using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControl : MonoBehaviour
{
    public int Power;
    public WheelCollider[] Wheels;
    public float Vertical;
    public float Horizontal;
    public int Angle = 45;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");


        for (int i = 0; i < Wheels.Length; i++)
        {
            Wheels[i].motorTorque = Power * Vertical;
        }
        Wheels[1].steerAngle = Angle * Horizontal;
        Wheels[0].steerAngle = Angle * Horizontal;

    }
}
