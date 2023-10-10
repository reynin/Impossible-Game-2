using System;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 20;
    private void OnTriggerEnter(Collision other)
    {
        Rigidbody rb = other.gameObject.GetComponent <Rigidbody>();
        Vector3 velocity = rb.velocity;
        velocity.y = jumpForce;
        rb.velocity = velocity;
    }
}