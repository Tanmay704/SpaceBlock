using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainaero : MonoBehaviour
{
    
    public float forwardForce = 4000f;
    public float sidewaysForce = 3f;


    void FixedUpdate()
    {
        //add forward force
    
            Rigidbody rb = GetComponent<Rigidbody>();

            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            transform.Translate(sidewaysForce * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, 0f);



            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.position.x > (Screen.width / 2))
                {
                    GoRight();
                }
                if (touch.position.x < (Screen.width / 2))
                {
                    GoLeft();
                }
            }
       
      void GoRight()
        {
            transform.position = new Vector3(transform.position.x + 1.75f, transform.position.y, transform.position.z);

        }

      void GoLeft()
        {
            transform.position = new Vector3(transform.position.x - 1.75f, transform.position.y, transform.position.z);

        }


        
    }


}