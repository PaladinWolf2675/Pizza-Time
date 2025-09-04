using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
     void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ya smacked a wall!!");
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.tag == "Pizza") 
        {
            Debug.Log("Pizza Picked up!");
        }

        if (other.tag == "Customer")
        {
            Debug.Log("Pizza Delivered!");
        }
        
    }
}
