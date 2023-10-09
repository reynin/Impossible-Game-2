using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; //Field

    private float jumpForce = 250;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
        if (rigidBody.velocity.y < -.1f)
        {
            rigidBody.AddForce(0, -1, 0);
        }
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump") && IsTouchingGround())
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.GetComponent<Rigidbody>();
            rb.AddForce(0,jumpForce, 0);
            rb.angularVelocity = new Vector3(2,0,0);
        }
        transform.Translate(0,0,speed, Space.World); //Moving forward
    }

    bool IsTouchingGround()
    {
        int layerMask = LayerMask.GetMask("Ground");
        return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
    }
}
