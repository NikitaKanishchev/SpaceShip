using System;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _bulletSpeed = 40f;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(_bullet, transform.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().velocity = Vector3.left * _bulletSpeed;
 
    }
    
}