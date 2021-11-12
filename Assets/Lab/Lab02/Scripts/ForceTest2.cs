using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTest2 : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 1f;

    public Transform upCube;
    public Transform downCube;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForceAtPosition(-Vector3.right * force, upCube.position);
        }
        if (Input.GetKey(KeyCode.B))
        {
            rb.AddForceAtPosition(-Vector3.right * force, downCube.position);
        }
    }
}
