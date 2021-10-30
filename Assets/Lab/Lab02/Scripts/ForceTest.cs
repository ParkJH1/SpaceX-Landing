using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTest : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5;

    public bool pressA = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector3(1, 0, 0);
        }
        else
        {
            rb.velocity = Vector3.zero;
        }


        if (Input.GetKey(KeyCode.A))
        {
            pressA = true;
        }
        else
        {
            pressA = false;
        }

        if (Input.GetKey(KeyCode.B))
        {
            //rb.AddForce(new Vector3(1, 2, 0) * speed * Time.deltaTime);
            rb.angularVelocity = new Vector3(1, 0, 0);
        }
        else
        {
            rb.angularVelocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.C))
        {
            rb.AddForce(new Vector3(-2, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(1, 1, 1) * speed * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        if (pressA)
        {
            rb.AddForce(new Vector3(0, 2, 0) * speed * Time.fixedDeltaTime);
        }
    }
}
