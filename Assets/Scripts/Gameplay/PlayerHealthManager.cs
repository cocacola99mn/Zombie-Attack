using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public int totalHealth;
    public int currentHealth;
    
    public GameObject thePlayer;
    public GameObject gameOver;

    public HealthBar healthBar;

    void Start()
    {
        currentHealth = totalHealth;
        healthBar.setMaxHealth(totalHealth);
    }

    void Update()
    {
        if(currentHealth <=0)
        {
            GetPlayerScore();
            gameObject.SetActive(false);
            gameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void DamagePlayer( int damageAmount)
    {
        thePlayer.GetComponent<Animation>().Play();
        currentHealth -= damageAmount;
        healthBar.setHealth(currentHealth);
    }

    public void GetPlayerScore()
    {
    }
}
