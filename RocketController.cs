using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    private Rigidbody rb;


    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0, 1, 0), ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(-1, 0, 0), ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector3(1, 0, 0), ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector3(0, 0, -1), ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector3(0, 0, 1), ForceMode.VelocityChange);
        }



    }
}
