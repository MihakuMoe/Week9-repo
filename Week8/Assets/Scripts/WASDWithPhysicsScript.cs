using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDWithPhysicsScript : MonoBehaviour
{
    public float force = 0.1f;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKey(KeyCode.W)){
            //rb.AddForce(new Vector3(0, force, 0));
            rb.velocity = new Vector3(0, force, 0);
        }
    }
}
