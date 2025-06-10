using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
     void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ya smacked a wall!!");
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Ya squished me!!");
    }
}
