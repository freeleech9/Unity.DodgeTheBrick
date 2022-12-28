using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 50f;
    public float sideForce = 500f;
    // Start is called before the first frame update
    void Start()
    {       
        //rb.useGravity = false;       
        //rb.AddForce(0, 200, 500);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0 );

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, -sideForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (rb.position.y < 13.51026f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
