using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody rb;

    public float rocketThrustPower = 3f;
    public float rocketTurnPower = 0.3f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        //Arrow Keys
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.transform.Rotate(0, 0, rocketTurnPower);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.transform.Rotate(0, 0, -(rocketTurnPower));
        }
        
        //SpaceBar
        if (Input.GetKey(KeyCode.Space))
        {
            Thrust();
        }
    }

    void Thrust()
    {
        rb.AddForce(transform.up * rocketThrustPower);
    }
}
