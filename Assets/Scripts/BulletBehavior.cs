using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private float onscreenDelay = 3f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(gameObject, onscreenDelay);
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroids")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}

