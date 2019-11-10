using System.Collections.Generic;
using UnityEngine;

public class p33move : MonoBehaviour
{
    public Rigidbody rb;
    public controlstate control;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (control.player == 3)
        {
            if (Input.GetKey("d"))
            {
                rb.AddForce(10, 0, 0);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-10, 0, 0);
            }
            if (Input.GetKey("w"))
            {
                rb.AddForce(0, 0, 10);
            }
            if (Input.GetKey("s"))
            {
                rb.AddForce(0, 0, -10);
            }
        }
    }
     void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
        if (collisionInfo.collider.name == "score")
        {
            control.p3_in = true;

        }
    }
}
