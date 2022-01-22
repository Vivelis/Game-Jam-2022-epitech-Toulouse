using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontalMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float verticalMovement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        movePlayer(horizontalMovement, verticalMovement);
    }

    void movePlayer(float _horizontalMovement, float _verticalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, _verticalMovement);
        Vector3 v3Velocity = rb.velocity;
        if (Input.GetButton("Horizontal") && Input.GetButton("Vertical"))
        {
            targetVelocity = targetVelocity / 2;
        }
        transform.Translate(targetVelocity * Time.deltaTime, Space.World);
    }
}
