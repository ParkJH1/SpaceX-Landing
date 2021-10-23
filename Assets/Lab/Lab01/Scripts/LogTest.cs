using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogTest : MonoBehaviour
{
    public int a = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("LogTest Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("LogTest Update" + a.ToString());
    }

    private void FixedUpdate()
    {

    }
}
