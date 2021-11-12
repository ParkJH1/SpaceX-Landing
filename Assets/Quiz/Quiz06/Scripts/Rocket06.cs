using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket06 : MonoBehaviour
{
    public Rigidbody rb;
    public bool engineOn = false;
    public float force = 10f;

    public Renderer floorRenderer;

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
            engineOn = true;
        }
        else
        {
            engineOn = false;
        }
    }

    private void FixedUpdate()
    {
        if (engineOn)
        {
            rb.AddForce(Vector3.up * force);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.y > 10f) {
            floorRenderer.material.color = Color.red;
        }
        else
        {
            floorRenderer.material.color = Color.green;
        }
    }
}
