using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyKillManager : MonoBehaviour
{
    public int health;
    private int currentHealth;
    
    public Text scoreText ;
    private static int score = 0;

    void Start()
    {
        currentHealth = health;
        scoreText = GameObject.FindWithTag("ScoreNum").GetComponent<Text>();
    }

    void Update()
    {
        scoreText.text = score.ToString();
        
        EnemyHealthZero();
    }

    public void DamageEnemy(int damage)
    {
        GetComponent<Animation>().Play();
        currentHealth -= damage;
    }

    public void EnemyHealthZero()
    {
        if (currentHealth <= 0)
        {
            //EnemyGenerator.Instance.enemyCounter--;
            Destroy(gameObject);
            score++;
        }
    }
}
