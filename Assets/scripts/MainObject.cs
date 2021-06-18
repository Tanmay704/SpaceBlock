

using UnityEngine;

public class MainObject : MonoBehaviour
{
    public float forwardForce = 7000f;
    public float sidewaysForce = 2500f;
 // we marked this as "fixed"update because we are using it to mess with unity physics.
    void FixedUpdate()
    {
        //add forward force
        Rigidbody rb = GetComponent<Rigidbody>();

        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }

}
