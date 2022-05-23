using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HpController : MonoBehaviour
{ 
    public int maxHealth = 5;
    public int currenthealth;
    public int damage;
    
    public HealthBar HealthBar;

     void Start()
    {
        currenthealth = maxHealth;
        HealthBar.SetMaxHealth(maxHealth);
    }
     
     
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Asteroids")
        {

            currenthealth -= damage;
            HealthBar.SetHealth(currenthealth);
            
            
            if (currenthealth <= 0)
            {
                Debug.Log("You lose!");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}
