using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rb;
    private Vector3 velocity = Vector3.zero;
    public Animator animator;

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
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            animator.SetBool("IsPressed", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            animator.SetBool("IsPressed", true);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
            animator.SetBool("IsPressed", true);
        else if (Input.GetKey(KeyCode.DownArrow))
            animator.SetBool("IsPressed", true);
        else
        {
            animator.SetBool("IsPressed", false);
        }
    }

    void movePlayer(float _horizontalMovement, float _verticalMovement)
    {
        Vector3 targetVelocity = new Vector2(_horizontalMovement, _verticalMovement);
        Vector3 v3Velocity = rb.velocity;
        transform.Translate(targetVelocity * Time.deltaTime, Space.World);
    }
}
