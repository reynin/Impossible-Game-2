using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; //Field
    public float jumpForce = 250;
    public float jumpSpinForward = 2;
    public float fallGravity = -1;
    public int targetFrameRate;
    
    private const float fallTolerance = -.1f;

    void Start()
    {
        Application.targetFrameRate = targetFrameRate;
    }

    private void FixedUpdate()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
        if (rigidBody.velocity.y < fallTolerance)
        {
            rigidBody.AddForce(0, fallGravity, 0);
        }

        rigidBody.velocity = new Vector3(rigidBody.velocity.x, rigidBody.velocity.y, speed);
    }
    // The Jump mechanic for player
    void JumpForce()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(0, jumpForce, 0);
        rb.angularVelocity = new Vector3(jumpSpinForward, 0, 0);
    }

    bool IsTouchingGround()
        {
            int layerMask = LayerMask.GetMask("Ground");
            return Physics.CheckBox(transform.position, transform.lossyScale / 1.99f, transform.rotation, layerMask);
        }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && IsTouchingGround())
        {
            JumpForce();
        }
        transform.Translate(0,0,speed, Space.World); //Moving forward
    }
}
