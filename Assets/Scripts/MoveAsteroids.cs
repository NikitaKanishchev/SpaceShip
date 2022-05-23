using System;
using UnityEngine;

public class MoveAsteroids : MonoBehaviour
{

   
    //Speed move
    public float _speed;
    private float onscreenDelay = 4f;

    private void Start()
    {
        Destroy(this.gameObject,onscreenDelay);
    }

    private void FixedUpdate()
    { 
        transform.Translate(new Vector3(1,0,0) * _speed);
    }
}
