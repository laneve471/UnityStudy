using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ch13Move : MonoBehaviour
{
    private float MoveSpeed = 10.0f;
    private float JumpForce = 10.0f;
    private int JumpCount = 2;

    private Rigidbody2D rb;
    private float InputX;
    private bool isGrounded = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float X = Input.GetAxis("Horizontal");
        //Vector3 MoveDir = new Vector3(X, 0, 0);
        //transform.position = MoveDir * Time.deltaTime * MoveSpeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(InputX * MoveSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        if (JumpCount == 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            // 추후
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        Debug.Log("점프 가능"); 
    }
}
