using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movementSpeed = 5f;

    Vector2 movementDir;

    void Update()
    {
        movementDir.x = Input.GetAxisRaw("Horizontal");
        movementDir.y = Input.GetAxisRaw("Vertical");   
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movementDir * movementSpeed * Time.fixedDeltaTime);
    }
}
