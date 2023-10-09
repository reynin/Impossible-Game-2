using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.04f; //Field
    public float jumpForce = 200;
    public float jumpSpinForward = 2;
    public float fallGravity = -1;
    public int targetFrameRate;
    
    private const float fallTolerance = -.1f;

    void Start() // To customize FPS
    {
        Application.targetFrameRate = targetFrameRate;
    }

    private void FixedUpdate()
    {
        Rigidbody rigidBody = gameObject.GetComponent<Rigidbody>();
        Vector3 velocity = rigidBody.velocity;
        if (rigidBody.velocity.y < fallTolerance)
        {
            rigidBody.AddForce(0, fallGravity, 0);
        }

        velocity.z = speed;
        rigidBody.velocity = velocity;
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
    }
}
