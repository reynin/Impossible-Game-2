using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; //Field

    private float jumpForce = 200;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.GetComponent<Rigidbody>();
            rb.AddForce(0,jumpForce, 0);
        }
        transform.Translate(0,0,speed); //Moving forward
    }
}
