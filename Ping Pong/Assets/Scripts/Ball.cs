using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float movementSpeed = 10f;

    private void Start()
    {
        Vector2 force = new Vector2(-1f,Random.Range(-1f,1f));
        rb.AddForce(force.normalized * movementSpeed);
    }

    private void FixedUpdate()
    {
        rb.velocity = rb.velocity.normalized * movementSpeed;
    }
}
