using UnityEngine;
using System.Collections;
//using System.Diagnostics;
using System;
//using System.Media;
using System.Security.Cryptography;

//Attach this script to an empty gameobject.
//When you click on a sprite with a collider it will tell you it's name.
public class VisionRayCast : MonoBehaviour
{

    public LayerMask mask;
    public float viewDistance;

    void FixedUpdate()
    {
        RaycastHit2D hitUp = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), viewDistance, mask);
        RaycastHit2D hitDown = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), viewDistance, mask);
        RaycastHit2D hitRight = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), viewDistance, mask);
        RaycastHit2D hitLeft = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.left), viewDistance, mask);

        if (hitUp.collider != null)
        {   
            Debug.Log("up" + hitUp.collider.name);
            Debug.Log(hitUp.distance);
        }
        if (hitDown.collider != null)
        {
            Debug.Log("down" + hitDown.collider.name);
            Debug.Log(hitDown.distance);
        }
        if (hitRight.collider != null)
        {
            Debug.Log("right" + hitRight.collider.name);
            Debug.Log(hitRight.distance);
        }
        if (hitLeft.collider != null)
        {
            Debug.Log("left" + hitLeft.collider.name);
            Debug.Log(hitLeft.distance);
        }
        else
        {
            Debug.Log("Nothing Detected");
        }
    }
}